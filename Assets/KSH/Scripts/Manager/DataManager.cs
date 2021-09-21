using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum MaterialPositionIndex
{
    Start ,
    StartEnd,
    Current
}

public class DataManager : Manager
{
    public static DataManager instance = null;

    [Header("Managers")]
    public CookingManager cooking;

    List<CookingMaterial> offerFood;

    public override void ManagerInit()
    {
        Debug.Log("DataManager");
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
