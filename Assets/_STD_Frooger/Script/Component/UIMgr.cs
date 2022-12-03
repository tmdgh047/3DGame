using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UIMgr : MonoBehaviour
{
	public FadeEffect fadeEffect;
	public void OnClickStartBtn()
	{
		fadeEffect.stopOut = false;
		//SceneManager.LoadScene("SampleScene");
	}
	public void OnClickOptionBtn()
	{
		SceneManager.LoadScene("OptUI");
	}
	public void OnClickCreditBtn()
	{
		SceneManager.LoadScene("CreUI");
	}
	public void OnClickESCBtn()
	{
		Application.Quit();
	}
}
