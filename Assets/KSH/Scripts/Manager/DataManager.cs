using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager instance = null;

    private void Awake()
    {
        if (instance.Equals(null))
            instance = this;
        else
            Debug.LogWarning("DataManager 중복");
    }
}
