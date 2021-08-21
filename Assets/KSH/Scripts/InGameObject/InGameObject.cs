using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameObject : MonoBehaviour
{
    public virtual void OnMouseDown()
    {
        Debug.Log("터치");
    }
}
