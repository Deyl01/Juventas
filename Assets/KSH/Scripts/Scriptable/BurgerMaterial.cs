using UnityEngine;

public enum MaterialType
{
    DownBread = 0,
    UpBread,
    Tomato,
    Meat,
    Cheese
}
[CreateAssetMenu(fileName = "BurgerMaterial", menuName = "NewBurgerMaterial/BurgerMaterial")]
public class BurgerMaterial : ScriptableObject
{

    public MaterialType type;
    public Sprite sprite;
    public string name;
}