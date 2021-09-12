using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_TimeLimit : UIScript
{
    public Image bar;

    float limitTime, curTime;

    public override void UiInit()
    {
        Debug.LogWarning("인자를 넣지 않음 UIInitArror");
    }

    public void UiInit(int _value)
    {
        limitTime = _value;
        curTime = 0;
    }

    void TimeOut()
    {
        Debug.Log("TimeOver");
        this.enabled = false;
    }

    void SetGauge()
    {
        bar.fillAmount = (limitTime - curTime) / limitTime;
    }

    void UpdateTimer()
    {
        curTime += Time.deltaTime;
        SetGauge();
        if(curTime >= limitTime)
            TimeOut();

    }

    void Update()
    {
        UpdateTimer();
    }
}
