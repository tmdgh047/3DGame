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
    public int gift = 0;
    public int score = 0;

    private int movekeydown = 0;

	protected static bool IsPause;

	void Start()
    {
        playerTr = GetComponent<Transform>();
        //downTr = GameObject.FindWithTag("DOWN").GetComponent<Transform>();
        //upTr = GameObject.FindWithTag("UP").GetComponent<Transform>();
        Vector3 pos = transform.position;

		IsPause = true;
	}

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            playerTr.transform.Translate(0, 0.2f, 0);
            movekeydown = 1;
            StartCoroutine(kongmove());

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerTr.transform.Translate(0, 0.2f, 0);
            movekeydown = 2;
            StartCoroutine(kongmove());
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            playerTr.transform.Translate(0, 0.2f, 0);
            movekeydown = 3;
            StartCoroutine(kongmove());
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            playerTr.transform.Translate(0, 0.2f, 0);
            movekeydown = 4;
            StartCoroutine(kongmove());
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
    }

    IEnumerator kongmove()
    {
        yield return new WaitForSeconds(0.2f);
        if (movekeydown == 1)
        playerTr.transform.Translate(speed, -0.2f, 0);
        else if (movekeydown == 2)
        playerTr.transform.Translate(0, -0.2f, speed);
        else if (movekeydown == 3)
        playerTr.transform.Translate(-speed, -0.2f, 0);
        else if (movekeydown == 4)
        playerTr.transform.Translate(0, -0.2f, -speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "GIFT")
        {
            gift += 1;
            Debug.Log("선물: " + gift);
            GameObject.Destroy(other.gameObject);
        }

        if (other.tag == "UP")
        {
            playerTr.Translate(1f, 10f, 0);
        }
        if (other.tag == "DOWN")
        {
            //playerTr.Translate(2f, 2f, 0);
        }

    }

    private void OnTriggerStay(Collider other)
    {

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
