using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OptMgr : MonoBehaviour
{
	public void OnClickOptToBackBtn()
	{
		SceneManager.LoadScene("MainUI");
	}
}
