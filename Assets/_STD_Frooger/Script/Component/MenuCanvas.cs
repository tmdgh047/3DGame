using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuCanvas : MonoBehaviour
{
	public PlayerCtrl playerCtrl;

	public GameObject Title; //����
	public GameObject Over; //�Ʒ���
	public GameObject Score;
	public GameObject Gift;
	public GameObject Top;
	public GameObject Pause;

	//�Ͻ������� ���� ��ü����
	public Train train;
	public Car car;

	// Start is called before the first frame update
	void Start()
    {
        
    }

	// Update is called once per frame
	void Update()
	{
		//Ÿ��Ʋ
		if (PlayerCtrl.IsGamePlay == false)
		{
			Title.SetActive(false);
			Score.SetActive(true);
			Gift.SetActive(true);
			Top.SetActive(true);
		}

		//���ӿ���
		if (PlayerCtrl.IsGameOver == true)
		{
			Over.SetActive(true);
		}
		else if (PlayerCtrl.IsGameOver == false)
		{
			Over.SetActive(false);
		}

		//�Ͻ�����
		if (PlayerCtrl.IsPause == true)
		{
			Pause.SetActive(true);
			train.moveSpeed = 0f;
			car.moveSpeed = 0f;
			playerCtrl.speed = 0;
			Time.timeScale = 0f;
		}
		else if (PlayerCtrl.IsPause == false)
		{
			Pause.SetActive(false);
			train.moveSpeed = 6f;
			car.moveSpeed = 3f;
			playerCtrl.speed = 1;
			Time.timeScale = 1f;
		}
	}
}
