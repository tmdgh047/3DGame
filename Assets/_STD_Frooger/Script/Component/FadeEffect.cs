using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class FadeEffect : MonoBehaviour
{
	public float animTime = 1.5f;
	private Image fadeImage;

	private float start = 1f;
	private float end = 0f;
	private float time = 0f;

	public bool stopIn = false;
	public bool stopOut = true;

	//private bool fadeOut = false;
	void Awake()
	{
		fadeImage = GetComponent<Image>();
	}

	// Update is called once per frame
	void Update()
	{
		if (stopIn == false && time <= animTime)
		{
			PlayFadeIn();
		}
		if (time >= animTime && stopIn == false)
		{
			stopIn = true;
			time = 0;
		}

		Debug.Log(stopOut);
		//if(OnClickStartBtn)
		{
			if (stopOut == false && time <= animTime)
			{
				PlayFadeOut();
			}
			if (time >= animTime && stopOut == false)
			{
				SceneManager.LoadScene("SampleScene");
				stopIn = false;
				stopOut = true;
				time = 0;
			}
		}
	}
	void PlayFadeIn()
	{
		time += Time.deltaTime / animTime;
		Color color = fadeImage.color;
		color.a = Mathf.Lerp(start, end, time);
		fadeImage.color = color;
	}
	void PlayFadeOut()
	{
		time += Time.deltaTime / animTime;
		Color color = fadeImage.color;
		color.a = Mathf.Lerp(end, start, time);
		fadeImage.color = color;
	}
}