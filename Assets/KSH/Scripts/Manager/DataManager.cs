using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager instance = null;

    [Header("Managers")]
    public CookingManager cooking;

    private void Awake()
    {
        if (instance.Equals(null))
            instance = this;
        else
            Debug.LogWarning("DataManager 중복");
    }
}
