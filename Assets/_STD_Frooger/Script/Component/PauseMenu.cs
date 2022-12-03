using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : PlayerCtrl
{
	public GameObject Canvas1;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (IsPause == false)
		{
			Canvas1.SetActive(true);
		}
		if (IsPause == true)
		{
			Canvas1.SetActive(false);
		}
	}
}
