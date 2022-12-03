using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public List<Transform> EnvironmentObjectList = new List<Transform>();
    public int startMinVal = -12;
    public int startMaxVal = 12;

    public int SpawnCreateRandom = 50;

    void GeneratorEnvirement()
    {
        int randomIndex = 0;
        int randomVal = 0;
        GameObject tempClone = null;
        Vector3 offsetpos = Vector3.zero;

        float posz = this.transform.position.z;

        for (int i = startMinVal; i < startMaxVal; ++i)
        {
            randomVal = Random.Range(0, 100);
            if (randomVal < SpawnCreateRandom || posz <= -5)
            {
                randomIndex = Random.Range(0, EnvironmentObjectList.Count);
                tempClone = GameObject.Instantiate(EnvironmentObjectList[randomIndex].gameObject);
                tempClone.SetActive(true);
                offsetpos.Set(i, 1f, 0f);

                tempClone.transform.SetParent(this.transform);
                tempClone.transform.localPosition = offsetpos;
            }
        }
    }
    void Start()
    {
        GeneratorEnvirement();

    }

    void Update()
    {
        
    }
}
