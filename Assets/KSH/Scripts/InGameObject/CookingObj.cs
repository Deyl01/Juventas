using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum CookingType
{
    MET,
    COOK
}

public class CookingObj : MonoBehaviour
{
    private void OnMouseDown()
    {
        DataManager.instance.ui.CookingListPopUp();
    }
}
