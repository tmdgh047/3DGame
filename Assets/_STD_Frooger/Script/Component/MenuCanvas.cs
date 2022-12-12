using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCanvas : PlayerCtrl
{
	public GameObject Pause;
	public GameObject Title;
	public GameObject Over;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {	//일시정지
		if (IsPause == false)
		{
			Pause.SetActive(true);
		}
		if (IsPause == true)	
		{
			Pause.SetActive(false);
		}

		//타이틀
		if(IsGamePlay==false)
		{
			Title.SetActive(false);
		}

		//게임오버
		if(IsGameOver==true)
		{
			Over.SetActive(true);
		}
	}
}
