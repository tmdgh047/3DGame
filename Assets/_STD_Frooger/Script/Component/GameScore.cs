using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameScore : MonoBehaviour
{
	public Text txtScore; //플레이씬 점수
	public Text Over_txtScore; //게임오버 최종점수
	public Text GiftScore; //선물 점수
	public Text Tot_highScore; //최고점수
	public Text Over_tot_highScore; //게임오버 최고점수
	public Text Start_tot_highScore; //게임시작 최고점수

	public int totScore = 0;
	public int highScore = 0;
	public int boxScore = 0;

	private int tot_HighScore = 0;

	// Start is called before the first frame update
	void Start()
	{
		TotalScore(0);
		BoxScore(0);
		tot_HighScore = PlayerPrefs.GetInt("HIGH_SCORE1",0); 
		Total_highScore();
	}
	// Update is called once per frame
	public void TotalScore(int score) //현재 점수
	{
		totScore += score; 
		if (highScore <= totScore)
		{
			highScore = totScore;
		}
		Total_highScore();

		txtScore.text = " :<color=#000000>" + highScore.ToString() + "</color>";
		Over_txtScore.text = txtScore.text;		
	}

	public void Total_highScore() //최고기록 점수
	{
		if (tot_HighScore <= highScore)
		{			
			tot_HighScore = highScore;
		}

		Tot_highScore.text = " :<color=#000000>" + tot_HighScore.ToString() + "</color>";

		Over_tot_highScore.text = Tot_highScore.text;
		Start_tot_highScore.text = Tot_highScore.text;

		PlayerPrefs.SetInt("HIGH_SCORE1", tot_HighScore);
		if(PlayerPrefs.HasKey("HIGH_SCORE1"))
		{
			Debug.Log(PlayerPrefs.GetInt("HIGH_SCORE1", 0));

		}
	}


	public void BoxScore(int gift) //선물 갯수 출력
	{
		boxScore += gift;
		GiftScore.text = " :<color=#000000>" + boxScore.ToString() + "</color>";
	}
	public void BoxPointScore(int giftscore) //선물 점수 증가
	{
		totScore += giftscore;
		highScore += giftscore;
		TotalScore(0);
	}

}