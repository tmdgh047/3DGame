using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentMapManager : MonoBehaviour
{
    public GameObject[] EnvironmentObjectArray;
    public Transform ParentTransform = null;

    public int minPosZ = -20;
    public int maxPosZ = 20;

    public void GeneratorLine()
    {
        //GameObject cloneObj = GameObject.Instantiate(road.gameObject);
        //cloneObj.SetActive(true);
        Vector3 offsetpos = Vector3.zero;
        //cloneObj.transform.SetParent();

    }
    void GeneratorRoundBlock()
    {

    }
    void GeneratorBackBlock()
    {

    }

    
    void Start()
    {
        for(int i = minPosZ; i < maxPosZ; ++i)
        {
            CloneRoad(i);
        }
    }

    void CloneRoad(int p_posz)
    {
        int randomindex=Random.Range(0, EnvironmentObjectArray.Length);
        GameObject cloneObj=GameObject.Instantiate(EnvironmentObjectArray[randomindex]);

        Vector3 offsetpos = Vector3.zero;
        offsetpos.z = (float)p_posz;
        cloneObj.transform.SetParent(ParentTransform);
        cloneObj.transform.position = offsetpos;

        int randomrot = Random.Range(0, 2);
        if (randomrot == 1)
        {
            //cloneObj.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
    }
    void Update()
    {
        
    }
}
