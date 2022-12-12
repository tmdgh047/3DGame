using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuCanvas : PlayerCtrl
{
	public GameObject Pause;
	public GameObject Title; //위로
	public GameObject Over; //아래로

	Vector3 offsetPos = Vector3.zero;

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
		if (IsGameOver==true)
		{
			Over.SetActive(true);
		}
		
	}
}
