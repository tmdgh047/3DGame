using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameScore : PlayerCtrl
{
	public Text txtScore; //플레이씬 점수
	public Text Over_txtScore; //게임오버 최종점수
	public Text GiftScore; //선물 점수
	public Text m_highScore; //최고점수

	public int totScore = 0;
	public int highScore = 0;
	public int boxScore = 0;
	public int tot_HighScore = 0;

	// Start is called before the first frame update
	void Start()
	{
		TotalScore(0);
		BoxScore(0);
	}
	// Update is called once per frame
	public void TotalScore(int score) //최종 점수
	{
		totScore += score;
		if (highScore <= totScore)
		{
			highScore = totScore;
		}
		txtScore.text = " : <color=#ff0000>" + highScore.ToString() + "</color>";
		Over_txtScore.text = txtScore.text;
	}
	public void Total_highScore(int score) //최고기록 점수
	{
		if (tot_HighScore< highScore) //최고기록 갱신의 경우
		{
			tot_HighScore = highScore;
		}
		Over_txtScore.text = " : <color=#ff0000>" + tot_HighScore.ToString() + "</color>";
	}
	public void BoxScore(int gift) //선물 갯수 출력
	{
		boxScore += gift;
		GiftScore.text = " : <color=#ff0000>" + boxScore.ToString() + "</color>";
	}
	public void BoxPointScore(int giftscore) //선물 점수 증가
	{
		totScore += giftscore;
		highScore += giftscore;
		TotalScore(0);
	}

}