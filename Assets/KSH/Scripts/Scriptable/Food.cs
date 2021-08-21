using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FoodType
{
    FoodMaterial,
    TrimmedMaterial,
    FinishedFood
}

[CreateAssetMenu(fileName = "Food", menuName = "New Food/Food")]
public class Food : ScriptableObject
{
    public string foodName;
    public string foodInfo;
    public FoodType foodType;
    public Sprite foodSprite;
    public Food[] ingredients;
}