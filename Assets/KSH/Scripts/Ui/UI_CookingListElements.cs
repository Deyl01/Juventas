using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_CookingListElements : MonoBehaviour
{
    public Food elementsFood;

    Image foodSprite;
    Text foodName;
    Text textFoodCookingTime;
    int foodCookingTime;


    private void Awake()
    {
        foodSprite.sprite = elementsFood.materialSprite;
        foodName.text = elementsFood.materialName;
        textFoodCookingTime.text = elementsFood.cookingTime.ToString();
        foodCookingTime = elementsFood.cookingTime;

    }
}
