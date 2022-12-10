using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameScore : PlayerCtrl
{
	public Text txtScore;
	public Text GiftScore;
	public int totScore = 0;
	public int boxScore = 0;
	public int highScore = 0;
	// Start is called before the first frame update
	void Start()
	{
		TotalScore(0);
		BoxScore(0);
	}
	// Update is called once per frame
	public void TotalScore(int score)
	{
		totScore += score;
		if (highScore <= totScore)
		{
			highScore = totScore;
		}
		txtScore.text = "���� : <color=#ff0000>" + highScore.ToString() + "</color>";
	}
	public void BoxScore(int gift) //���� ���� ���
	{
		boxScore += gift;
		GiftScore.text = "���� : <color=#ff0000>" + boxScore.ToString() + "</color>";
	}
	public void BoxPointScore(int giftscore) //���� ���� ����
	{
		totScore += giftscore;
		highScore += giftscore;
		TotalScore(0);
	}

}