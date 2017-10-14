using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enemyCount : MonoBehaviour
{
	public GameObject nextLevelUI;


	void Start ()
	{
		nextLevelUI.SetActive (false);
	}

	void Update ()
	{
		var enemy = GameObject.FindGameObjectsWithTag ("enemy").Length;
		if (enemy == 0) {
			nextLevelUI.SetActive (true);
		}
	}

	public void Menu ()
	{
		SceneManager.LoadScene (1);
	}
}

