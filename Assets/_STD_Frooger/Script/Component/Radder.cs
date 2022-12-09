using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radder : MonoBehaviour
{
    public Transform playerTr;
    public Transform upTr;
    public Transform downTr;
    void Start()
    {
        playerTr = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

    }
}
