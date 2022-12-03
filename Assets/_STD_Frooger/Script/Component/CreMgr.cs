using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CreMgr : MonoBehaviour
{
	// Start is called before the first frame update
	public void OnClickCretoBackBtn()
	{
		SceneManager.LoadScene("MainUI");
	}
}
