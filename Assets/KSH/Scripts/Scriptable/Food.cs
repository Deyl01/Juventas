using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FoodType
{
    Material,
    FinishedFood
}

public enum FoodKind
{
    //원자재
    Meat,
    Bread,
    Vegetable,

    //완제품
    Hamburger
}

[CreateAssetMenu(fileName = "Food", menuName = "New Food/Food")]
public class Food : ScriptableObject
{
    public string materialName; //원자재 한글명
    public string TrimmedMeaterialName; //손질된 재료 한글명
    public FoodType foodType; //타입
    public FoodKind foodKind; //음식 종류
    public Sprite materialSprite; //원자재 이미지  
    public Sprite trimmedMaterialSprite;//손질된 재료 이미지
    public int cookingTime; //조리시간
    public Food[] ingredients; //재료 (햄버거)
}