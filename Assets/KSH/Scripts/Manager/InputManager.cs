using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // void Update()
    // {
    //     if(Input.GetTouch(0))
    //     {
    //         Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //         RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);
    //         if(hit.collider != null)
    //         {
    //             Debug.Log(hit.collider.gameObject.name);
    //         }
    //     }
    // }
    private void OnMouseDown()
    {
        Debug.Log("터치");
    }
}
