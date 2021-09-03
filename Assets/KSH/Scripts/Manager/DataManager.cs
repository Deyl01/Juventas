using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : Manager
{
    public static DataManager instance = null;

    [Header("Managers")]
    public CookingManager cooking;

    public override void ManagerInit()
    {
        Debug.Log("datamanager");
    }

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Debug.LogWarning("DataManager 중복");
    }

    private void Start()
    {
        cooking.ManagerInit();
    }
}
