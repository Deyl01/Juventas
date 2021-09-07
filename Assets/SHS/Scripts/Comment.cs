using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class Comment : MonoBehaviour
{
    string[] commentList;



    public void ReadFromList()
    {
        commentList = File.ReadAllLines(Application.dataPath + "/SHS" + "/Resources" + "/commentList.txt");

        print(commentList[1]);
    }


    //^태스트용
}
