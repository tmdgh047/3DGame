using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerCtrl : MonoBehaviour
{
    private GameScore gamescore;
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
        gamescore = GameObject.Find("GameScore").GetComponent<GameScore>();
        //downTr = GameObject.FindWithTag("DOWN").GetComponent<Transform>();
        //upTr = GameObject.FindWithTag("UP").GetComponent<Transform>();
        Vector3 pos = transform.position;

        IsPause = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            playerTr.transform.Translate(0, 0.2f, 0);
            movekeydown = 1;
            StartCoroutine(kongmove());

            gamescore.TotalScore(1);
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

            gamescore.TotalScore(-1);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            playerTr.transform.Translate(0, 0.2f, 0);
            movekeydown = 4;
            StartCoroutine(kongmove());
        }

  //      if (Input.GetKeyDown(KeyCode.Escape)) //�Ͻ�����
  //      {
  //          if(IsPause==false)
  //          {
  //              Time.timeScale = 0;
  //              speed = 0;
  //              IsPause = true;
  //              return;
  //          }
  //          if(IsPause==true)
  //          {
		//		Time.timeScale = 1;
  //              speed = 1;
		//		IsPause = false;
		//		return;
		//	}
		//}

}

IEnumerator kongmove()
    {
        yield return new WaitForSeconds(0.2f);
        if (movekeydown == 1) //w
            playerTr.transform.Translate(0, -0.2f, speed);
        else if (movekeydown == 2) //a
            playerTr.transform.Translate(-speed, -0.2f, 0);
        else if (movekeydown == 3) //s
            playerTr.transform.Translate(0, -0.2f, -speed);
        else if (movekeydown == 4) //d
            playerTr.transform.Translate(speed, -0.2f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "GIFT")
        {
            gift += 1;
            gamescore.BoxScore(1);
            Debug.Log("����: " + gift);
            GameObject.Destroy(other.gameObject);
        }

        if (other.tag == "UP")
        {
            playerTr.Translate(0f, 10f, 0);
        }
        if (other.tag == "DOWN")
        {
            //playerTr.Translate(2f, 2f, 0);
        }

		if (other.tag == "CAR") // �����̴� ��ֹ�
		{
			Debug.Log("�����̴� �� ����");
		}

		if (other.tag == "OBSTACLE") //�� ���θ��� ��ֹ�
		{
            Debug.Log("��ֹ� ����");
		}

		if (other.tag == "SLED") // ���
		{
			Debug.Log("��� ����. ���� ����");
		}
	}

    private void OnTriggerStay(Collider other)
    {
		if (other.tag == "CHIMNEY" && gift >= 1)
		{
            score = gift;
            gift = 0;
            gamescore.boxScore = 0;
            gamescore.GiftScore.text = "���� : <color=#ff0000>" + gamescore.boxScore.ToString() + "</color>";
            Debug.Log("����: " + score);
            gamescore.BoxPointScore(score * 5);
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
