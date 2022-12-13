using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class PlayerCtrl : MonoBehaviour
{
    private GameScore gamescore;
    public Transform playerTr;
    public Transform upTr;
    public Transform downTr;

    public Transform currentTr;

    public AudioClip audioGift;
    public AudioClip audioTrain;
    public AudioClip audioCar;

    AudioSource audioSource;

	public int speed = 1;
    public int gift = 0;
    public int score = 0;

    private int movekeydown = 0;

	public static bool IsGamePlay;
	public static bool IsGameOver;
	public static bool IsPause;
    private void Awake()
    {
		audioSource = GetComponent<AudioSource>();
    }
    void Start()
    {
        playerTr = GetComponent<Transform>();
        gamescore = GameObject.Find("GameScore").GetComponent<GameScore>();
        //downTr = GameObject.FindWithTag("DOWN").GetComponent<Transform>();
        //upTr = GameObject.FindWithTag("UP").GetComponent<Transform>();
        Vector3 pos = transform.position;


		IsPause = false;
        IsGamePlay = true;
        IsGameOver = false;
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            IsGamePlay = false;

			playerTr.transform.Translate(0, 0.2f, 0);
            transform.rotation = Quaternion.Euler(0, 90, 0);
            movekeydown = 1;
            StartCoroutine(kongmove());

            gamescore.TotalScore(1);
		}
        if (Input.GetKeyDown(KeyCode.A))
        {
			IsGamePlay = false;

			playerTr.transform.Translate(0, 0.2f, 0);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            movekeydown = 2;
            StartCoroutine(kongmove());
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
			IsGamePlay = false;
			playerTr.transform.Translate(0, 0.2f, 0);
            transform.rotation = Quaternion.Euler(0, -90, 0);
            movekeydown = 3;
            StartCoroutine(kongmove());

            gamescore.TotalScore(-1);
		}
        if (Input.GetKeyDown(KeyCode.D))
        {
			IsGamePlay = false;

			playerTr.transform.Translate(0, 0.2f, 0);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            movekeydown = 4;
            StartCoroutine(kongmove());
        }

		if (Input.GetKeyDown(KeyCode.Space)) //일시정지
		{
            Debug.Log(transform.name);
            if (IsPause == false)
            {
				IsPause = true;
            }
            else if (IsPause == true)
            {
				IsPause = false;
            }
        }


        if(IsGameOver==true&&Input.anyKeyDown) //게임오버 -> 재시작
        {
            IsGameOver = false;
            IsGamePlay = false;

			playerTr.position = currentTr.position;

            score = 0;
			gamescore.highScore = 0;
            gamescore.totScore = 0;
			gamescore.txtScore.text = " :<color=#000000>" + gamescore.highScore.ToString() + "</color>";
			gift = 0;
			gamescore.GiftScore.text = " :<color=#000000>" + gift.ToString() + "</color>";
		}

    }

IEnumerator kongmove()
    {
        yield return new WaitForSeconds(0.2f);
        if (movekeydown == 1) //w
            playerTr.transform.Translate(0, -0.2f, speed);
        else if (movekeydown == 2) //a
            playerTr.transform.Translate(0, -0.2f, speed);
        else if (movekeydown == 3) //s
            playerTr.transform.Translate(0, -0.2f, speed);
        else if (movekeydown == 4) //d
            playerTr.transform.Translate(0, -0.2f, speed);
    }


    private void OnTriggerEnter(Collider other)
    {
		if (other.tag == "GIFT")
        {
            gift += 1;
            gamescore.BoxScore(1);
            GameObject.Destroy(other.gameObject);

            audioSource.clip = audioGift;
            audioSource.Play();
		}

        if (other.tag == "UP")
        {
            playerTr.Translate(0f, 10f, 0);
        }
        if (other.tag == "DOWN")
        {
            //playerTr.Translate(2f, 2f, 0);
        }

		if (other.tag == "CAR") // 움직이는 장애물
		{
			IsGameOver = true;
			audioSource.clip = audioCar; 
			audioSource.Play();
		}
        if(other.tag == "Train")
        {
			IsGameOver = true;
			audioSource.clip = audioTrain;
			audioSource.Play();
		}

		if (other.tag == "OBSTACLE") //길 가로막는 장애물
		{
		}

		if (other.tag == "SLED") // 썰매
		{
            IsGameOver = true;
			audioSource.clip = audioTrain;
			audioSource.Play();
		}
	}

    private void OnTriggerStay(Collider other)
    {
		if (other.tag == "CHIMNEY" && gift >= 1)
		{
            score = gift;
            gift = 0;
            gamescore.boxScore = 0;
            gamescore.GiftScore.text = " :<color=#000000>" + gamescore.boxScore.ToString() + "</color>";
            gamescore.BoxPointScore(score * 5);

			audioSource.clip = audioGift;
			audioSource.Play();
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
