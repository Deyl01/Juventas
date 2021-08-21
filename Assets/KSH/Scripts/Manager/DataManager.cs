using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : ManagerScript
{
    public static DataManager instance = null;

    [Header("Managers")]
    public InputManager input;

    private void Awake()
    {
        if(instance == null)
            instance = this;
        else 
        {
            Debug.LogWarning("중복");
        }
    }
}
