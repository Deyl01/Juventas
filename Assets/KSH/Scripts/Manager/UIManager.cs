using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject cookingList;

    public void CookingListPopUp() //요리 목록 켜기
    {
        if(!cookingList.activeSelf)
        {
            cookingList.SetActive(true);
        }
    }
}
