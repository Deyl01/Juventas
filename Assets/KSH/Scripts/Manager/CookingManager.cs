using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//스택 최대 7개
public class CookingManager : Manager
{
    public BurgerMaterial[] burgerMaterials;

    public GameObject foodMaterialPrefab;

    public Transform[] materialPosition; // start | StartEnd | current

    public Vector3 deltaPosition;

    List<CookingMaterial> curMatList = new List<CookingMaterial>();

    public override void ManagerInit()
    {
        materialPosition[2].position = materialPosition[1].position;
    }

    public void SetMaterialButtonDown(int _index)
    {
        SpawnMaterial(_index);
        MaterialAddDeltaPositoin();
    }

    public void ResetMaterialButtondown() => ResetMaterial();

    int i = 0;
    void SpawnMaterial(int _index)
    {
        if (i < 7) {
            GameObject tmp = Instantiate<GameObject>(foodMaterialPrefab);
            Sprite bgSprite = tmp.GetComponent<SpriteRenderer>().sprite;
            CookingMaterial tmpScript = tmp.GetComponent<CookingMaterial>();

            tmp.GetComponent<SpriteRenderer>().sprite = burgerMaterials[_index].sprite;

            bgSprite = burgerMaterials[_index].sprite;

            Debug.Log("112213");

            curMatList.Add(tmpScript);

            tmpScript.endPos = materialPosition[2].position;
            tmp.transform.position = materialPosition[0].position;
            i++;
        }
        
    }

    void MaterialAddDeltaPositoin()
    {
        Vector3 tmp = materialPosition[2].position;
        tmp += deltaPosition;
        materialPosition[2].position = tmp;
    }

    void ResetMaterial() //쌓인 재료 전부 제거
    {
        for(int i = 0 ; i < curMatList.Count; i++)
        {
            Destroy(curMatList[i].gameObject);
        }
        materialPosition[2].position = materialPosition[1].position;
        curMatList.Clear();
    }

    public void ServiseFood()
    {
        //todo 손님한테 제공
        
        foreach(CookingMaterial i in curMatList)
        {
            
        }
        
        ResetMaterial();

    }
}
