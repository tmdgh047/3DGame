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
		txtScore.text = "점수 : <color=#ff0000>" + totScore.ToString() + "</color>";
	}
	public void BoxScore(int gift)
	{
		boxScore += gift;
		GiftScore.text = "선물 : <color=#ff0000>" + boxScore.ToString() + "</color>";
	}
}
