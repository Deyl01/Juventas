using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingMaterial : MonoBehaviour
{

    public Vector3 endPos;

    public float moveSpeed;

    Transform tr;
    public SpriteRenderer render;

    private void Start()
    {
        tr = GetComponent<Transform>();
        render = GetComponent<SpriteRenderer>();

        Debug.Log(endPos);
    }

    private void Update()
    {
        if (!tr.position.Equals(endPos))
        {
            tr.position = Vector3.MoveTowards(tr.position, endPos, moveSpeed * Time.deltaTime);
        }
    }

    public void SetMaterial(MaterialType _index)
    {
        render.sprite = DataManager.instance.cooking.matSprites[(int)_index];
    }
}
