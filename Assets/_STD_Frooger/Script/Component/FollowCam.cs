using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform camTr;
    public Transform targetTr;
    public float dist = 10;
    public float height = 10;
    void Start()
    {
        camTr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(camTr.transform.position, targetTr.position + (Vector3.left * 6.5f) + (Vector3.up * 8f) + (Vector3.back * 8f), Time.deltaTime * 2f); ;
    }
}
