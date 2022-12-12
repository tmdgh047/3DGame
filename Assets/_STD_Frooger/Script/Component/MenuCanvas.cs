using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuCanvas : PlayerCtrl
{
	public GameObject Pause;
	public GameObject Title; //����
	public GameObject Over; //�Ʒ���

	Vector3 offsetPos = Vector3.zero;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {	//�Ͻ�����
		if (IsPause == false)
		{
			Pause.SetActive(true);
		}
		if (IsPause == true)	
		{
			Pause.SetActive(false);
		}

		//Ÿ��Ʋ
		if(IsGamePlay==false)
		{			
			Title.SetActive(false);
		}

		//���ӿ���
		if (IsGameOver==true)
		{
			Over.SetActive(true);
		}
		
	}
}
