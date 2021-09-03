using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MaterialType
{
    DownBread = 0,
    OnBread,
    Vegetable,
    Meat,
    Onion,
    Cheese
}

public class CookingMaterial : MonoBehaviour
{
    public Sprite[] matSprites;

    public Vector2 endPos;

    public float moveSpeed;

    Transform tr;
    public SpriteRenderer render;

    private void Start()
    {
        tr = GetComponent<Transform>();
        render = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (!tr.position.Equals(endPos))
        {
            tr.position = Vector2.MoveTowards(tr.position, endPos, moveSpeed * Time.deltaTime);
        }
    }

    public void SetMaterial(MaterialType _index)
    {
        render.sprite = matSprites[(int)_index];
    }
}
