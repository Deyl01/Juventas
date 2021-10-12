using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingMaterial : MonoBehaviour
{

    public Vector3 endPos;
    public Vector3 S_EndPos;

    public float moveSpeed;

    Transform tr;
    SpriteRenderer render;



    private void Start()
    {
        tr = GetComponent<Transform>();
        render = GetComponent<SpriteRenderer>();
        S_EndPos = tr.transform.position;
        StartCoroutine(WaitAnim());

    }

    private void Update()
    {
        if (!tr.position.Equals(endPos))
        {
            tr.position = Vector3.MoveTowards(tr.position, S_EndPos, moveSpeed * Time.deltaTime);
        }
    }

    IEnumerator WaitAnim()
    {
        yield return new WaitForSeconds(1);
        S_EndPos = endPos;
    }
}
