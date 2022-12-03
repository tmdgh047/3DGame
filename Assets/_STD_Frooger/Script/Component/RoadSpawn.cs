using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawn : MonoBehaviour
{
    public List<GameObject> spawnList = new List<GameObject>();
    public List<GameObject> spawnList2 = new List<GameObject>();
    public Transform parentTransform = null;
    public int minPosZ = 0;
    public int maxPosZ = 20;
    public int generationPoint = 70;

    void Start()
    {
        for(int i = minPosZ; i < maxPosZ; i++)
        {
            CloneRoad(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CloneRoad(int i)
    {
        int randomIndex = Random.Range(0, spawnList.Count);
        GameObject cloneObj = GameObject.Instantiate(spawnList[randomIndex]);
        Vector3 offsetpos = Vector3.zero;
        cloneObj.SetActive(true);
        offsetpos.z = (float)i;
        cloneObj.transform.SetParent(parentTransform);
        cloneObj.transform.position = offsetpos;
        int randomIndex2 = Random.Range(0, 10);
        int randomIndex3 = Random.Range(0, 100);

        if (randomIndex3 < generationPoint)
        {

        GameObject cloneObj2 = GameObject.Instantiate(spawnList2[randomIndex]);
        Vector3 offsetpos2 = Vector3.zero;
        cloneObj2.SetActive(true);
        offsetpos2.y = 1f;
        offsetpos2.z = (float)i;
        offsetpos2.x = (float)randomIndex2;
        cloneObj2.transform.SetParent(parentTransform);
        cloneObj2.transform.position = offsetpos2;
        }
    }
}
