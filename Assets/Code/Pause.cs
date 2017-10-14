using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{

	public GameObject pauseUI;

	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape) || Input.GetKeyDown (KeyCode.P)) {
			PauseMenu ();
		}
	}

	public void PauseMenu ()
	{
		pauseUI.SetActive (!pauseUI.activeSelf);
	    
		if (pauseUI.activeSelf) {
			Time.timeScale = 0f;
		} else {
			Time.timeScale = 1f;
		}

	}
}

