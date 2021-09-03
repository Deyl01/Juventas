using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum MaterialPositionIndex
{
    Start ,
    StartEnd,
    Current
}

public class CookingManager : Manager
{
    public GameObject foodMaterialPrefab;
    public Transform[] materialPosition; // start | StartEnd | current
    public float deltaPosition;

    List<CookingMaterial> curMatList = new List<CookingMaterial>();

    public override void ManagerInit()
    {
        materialPosition[2].position = materialPosition[1].position;
    }

    public void SetMaterialButtonDown(int _index)
    {
        SapwnMaterial(_index);
        MaterialAddDeltaPositoin();
    }

    public void ResetMaterialButtondown() => ResetMaterial();
    

    void SapwnMaterial(int _index)
    {
        GameObject tmp = Instantiate<GameObject>(foodMaterialPrefab);
        CookingMaterial tmpScript = tmp.GetComponent<CookingMaterial>();
        curMatList.Add(tmpScript);
        tmpScript.SetMaterial((MaterialType)_index);
        tmpScript.endPos = materialPosition[2].position;
        tmp.transform.position = materialPosition[0].position;
    }

    void MaterialAddDeltaPositoin()
    {
        Vector2 tmp = materialPosition[2].position;
        tmp.y += deltaPosition;
        materialPosition[2].position = tmp;
    }

    void ResetMaterial()
    {
        for(int i = 0 ; i < curMatList.Count; i++)
        {
            Destroy(curMatList[i].gameObject);
        }
        // materialPosition[(int)MaterialPositionIndex.Current].position = materialPosition[((int)MaterialPositionIndex.StartEnd)].position;
        materialPosition[2].position = materialPosition[1].position;
        curMatList.Clear();
    }
}
