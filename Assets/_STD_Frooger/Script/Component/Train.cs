using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train : MonoBehaviour
{
    public float moveSpeed = 6.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float move = moveSpeed * Time.deltaTime;

        this.transform.Translate(move, 0, 0);
    }
}
