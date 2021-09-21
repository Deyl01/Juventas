using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_ScrollInput : MonoBehaviour
{
    public Vector2 leftTop;
    public Vector2 rightBottom;

    private Vector2 touchBeganPos;
    private Vector2 touchEndedPos;
    private Vector2 touchDif;

    [SerializeField]
    private float swipeSensitivity;

    List<CookingMaterial> curMatList;

    private void Update()
    {
        Swipe1();
    }

    //스와이프와 터치
    public void Swipe1()
    {
        if (Input.touchCount > 0 &&
            Input.GetTouch(0).position.y < leftTop.y &&
            Input.GetTouch(0).position.y > rightBottom.y
            )
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                touchBeganPos = touch.position;
            }
            if (touch.phase == TouchPhase.Ended)
            {
                touchEndedPos = touch.position;
                touchDif = (touchEndedPos - touchBeganPos);

                //스와이프. 터치의 x이동거리나 y이동거리가 민감도보다 크면
                if (Mathf.Abs(touchDif.y) > swipeSensitivity || Mathf.Abs(touchDif.x) > swipeSensitivity)
                {
                    if (touchDif.x > 0 && Mathf.Abs(touchDif.y) < Mathf.Abs(touchDif.x))
                    {
                        DataManager.instance.cooking.ServiseFood();
                        Debug.Log("right");
                    }
                    else if (touchDif.x < 0 && Mathf.Abs(touchDif.y) < Mathf.Abs(touchDif.x)) //left
                    {
                        DataManager.instance.cooking.ResetMaterialButtondown();
                        Debug.Log("Cleare Food");
                    }
                }
                //터치.
                else
                {
                    Debug.Log("touch");
                }
            }
        }
    }
}
