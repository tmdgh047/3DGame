using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float rangeDestroy = 20f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movex = moveSpeed * Time.deltaTime;
        Vector3 tgPos = transform.position;
        tgPos.x += 20;
        this.transform.Translate(movex, 0f, 0f);

        //this.transform.position = Vector3.MoveTowards(this.transform.position, tgPos, movex);
        if (this.transform.localPosition.x >= rangeDestroy)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
