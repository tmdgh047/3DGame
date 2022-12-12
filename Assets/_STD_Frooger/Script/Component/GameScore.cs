using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameScore : PlayerCtrl
{
	public Text txtScore; //�÷��̾� ����
	public Text Over_txtScore; //���ӿ��� ��������
	public Text GiftScore; //���� ����
	public Text m_highScore; //�ְ�����

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
	public void TotalScore(int score) //���� ����
	{
		totScore += score;
		if (highScore <= totScore)
		{
			highScore = totScore;
		}
		txtScore.text = " : <color=#ff0000>" + highScore.ToString() + "</color>";
		Over_txtScore.text = txtScore.text;
	}
	public void Total_highScore(int score) //�ְ��� ����
	{
		if (tot_HighScore< highScore) //�ְ��� ������ ���
		{
			tot_HighScore = highScore;
		}
		Over_txtScore.text = " : <color=#ff0000>" + tot_HighScore.ToString() + "</color>";
	}
	public void BoxScore(int gift) //���� ���� ���
	{
		boxScore += gift;
		GiftScore.text = " : <color=#ff0000>" + boxScore.ToString() + "</color>";
	}
	public void BoxPointScore(int giftscore) //���� ���� ����
	{
		totScore += giftscore;
		highScore += giftscore;
		TotalScore(0);
	}

}