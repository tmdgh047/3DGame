using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public Car cloneTarget_0 = null;
    public Car cloneTarget_1 = null;
    public Car cloneTarget_2 = null;
    public Transform genarationPos = null;
    public int generationPersent = 50;

    public float cloneDelaySec = 1.0f;

    protected float NextSecToClone = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float currSec = Time.time;
        if (NextSecToClone <= currSec)
        {
            int randomVal = Random.Range(0, 100);
            if (randomVal < generationPersent)
            {
                cloneCar();
            }
            NextSecToClone = currSec + cloneDelaySec;
        }
    }

    void cloneCar()
    {
        Transform clonePos = genarationPos;
        Vector3 offsetpos = clonePos.position;
        //offsetpos.y = 0f;
        int randomVal = Random.Range(0, 3);
        
        if(randomVal == 0)
        {
            GameObject cloneObj = GameObject.Instantiate(cloneTarget_0.gameObject,
                offsetpos,
                genarationPos.rotation,
                this.transform);
            cloneObj.SetActive(true);
        }
        else if(randomVal == 1)
        {
            GameObject cloneObj = GameObject.Instantiate(cloneTarget_1.gameObject,
                offsetpos,
                genarationPos.rotation,
                this.transform);
            cloneObj.SetActive(true);
        }
        else if(randomVal == 2)
        {
            GameObject cloneObj = GameObject.Instantiate(cloneTarget_2.gameObject,
                offsetpos,
                genarationPos.rotation,
                this.transform);
            cloneObj.SetActive(true);
        }
    }
}
