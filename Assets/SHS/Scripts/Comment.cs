using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class Comment : MonoBehaviour
{
    public string[] commentListPositive;
    public string[] commentListNeutral;
    public string[] commentListNegative;

//    게임 시작에만 쓸 스크립트
    public void CommentReadFromList()
    {
        TextAsset commentFile = Resources.Load("commentList") as TextAsset;
        StringReader stringReader = new StringReader(commentFile.text);

        while (stringReader != null)
        {
            string line = stringReader.ReadLine();

            if (line == null)
                break;

            commentArray(int.Parse(line.Split(',')[1]),line.Split(',')[0]);

        }
        stringReader.Close();
//        Debug.Log("1");
    }
    void commentArray(int Type, string commntText) // 택스트 태그를 보고 분류
    {
//        print(commentListPositive.Length);
        switch (Type) {
            case 1:
                commentListPositive[commentListPositive.Length -1] = commntText;
                Array.Resize(ref commentListPositive, commentListPositive.Length + 1);
                break;
            case 0:
                commentListNeutral[commentListNeutral.Length - 1] = commntText;
                Array.Resize(ref commentListNeutral, commentListNeutral.Length + 1);
                break;
            case -1:
                commentListNegative[commentListNegative.Length - 1] = commntText;
                Array.Resize(ref commentListNegative, commentListNegative.Length + 1);
                break;
        }
//        Debug.Log(commntText);
    }



    //^태스트용
}
