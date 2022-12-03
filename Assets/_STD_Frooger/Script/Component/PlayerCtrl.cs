using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerCtrl : MonoBehaviour
{
    public Transform playerTr;
    public Transform upTr;
    public Transform downTr;
    public int speed = 1;
    protected LayerMask m_layerMask;
    public int gift = 0;
    public int score = 0;

	protected static bool IsPause;

	void Start()
    {
        playerTr = GetComponent<Transform>();
        downTr = GameObject.FindWithTag("DOWN").GetComponent<Transform>();
        upTr = GameObject.FindWithTag("UP").GetComponent<Transform>();
        Vector3 pos = transform.position;

		IsPause = true;
	}

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            playerTr.transform.Translate(0, 0, speed);

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerTr.transform.Translate(-speed, 0, 0);

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            playerTr.transform.Translate(0, 0, -speed);

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            playerTr.transform.Translate(speed, 0, 0);

        }

		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (IsPause == true)
			{
				Time.timeScale = 0;
                speed = 0;
				IsPause = false;
				return;
			}
			if (IsPause == false)
			{
				Time.timeScale = 1;
                speed = 1;
				IsPause = true;
				return;
			}
		}
		Vector3 direction = Vector3.zero;
        RaycastHit hitObj;
        if (Physics.Raycast(this.transform.position, direction, out hitObj,1f, m_layerMask))
        {

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "GIFT")
        {
            gift += 1;
            Debug.Log("선물: " + gift);
            GameObject.Destroy(other.gameObject);
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "UP" && Input.GetKeyDown(KeyCode.Space))
        {
            playerTr.transform.position = downTr.transform.position;
            playerTr.transform.Translate(0, 0.5f, 0);

        }
        else if (other.tag == "DOWN" && Input.GetKeyDown(KeyCode.Space))
        {
            playerTr.transform.position = upTr.transform.position;
            playerTr.transform.Translate(0, 1f, 0);

        }

        if (other.tag == "CHIMNEY" && gift >= 1)
        {
            gift -= 1;
            score += 1;
            Debug.Log("점수: " + score);
        }
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    if (Input.GetKey(KeyCode.S))
    //    {
    //        playerTr.transform.Translate(0, 0, speed);
    //    }
    //}
}
