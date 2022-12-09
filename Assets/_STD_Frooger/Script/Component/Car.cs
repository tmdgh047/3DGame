using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    public float rangeDestroy = -20f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movex = moveSpeed * Time.deltaTime;
        //Vector3 tgPos = transform.position;
        //tgPos.x += 20;
        this.transform.Translate(0, 0, -movex);

        //this.transform.position = Vector3.MoveTowards(this.transform.position, tgPos, movex);
        if (this.transform.localPosition.z >= rangeDestroy)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
