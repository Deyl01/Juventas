using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Manager
{

    public UI_TimeLimit timer;

    void Start()
    {
        timer.UiInit(10);
    }

}
