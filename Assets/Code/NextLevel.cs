using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevel : MonoBehaviour
{

		
	public void Menu ()
	{
		SceneManager.LoadScene (0);
	}

	public void nextLevel ()
	{
		SceneManager.LoadScene (2);
	}
}
