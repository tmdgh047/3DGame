using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnMgr : MonoBehaviour
{
	public void OnClickPlayBtn()
	{
		PlayerCtrl.IsPause = false;
	}
	public void OnClickQuitBtn()
	{
		Application.Quit(); 
	} 
}
