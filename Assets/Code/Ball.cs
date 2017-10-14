using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
	private bool held = false;
	public Rigidbody2D rb;
	public float releaseTime = .1f;
	public GameObject nextBall;
	public GameObject player;


	void Update ()
	{   
		if (held) {
			rb.position = Camera.main.ScreenToWorldPoint (Input.mousePosition); 
			//tranforms pos of screns space to world space using mouse position

		}
	}

	void OnMouseDown ()
	{
		held = true;
		rb.isKinematic = true;
	}

	void OnMouseUp ()
	{
		held = false;
		rb.isKinematic = false;
		StartCoroutine (Release ());
	}
	//coroutine to restart execution
	IEnumerator Release ()
	{
		var enemy = GameObject.FindGameObjectsWithTag ("enemy").Length;
		yield return new WaitForSeconds (releaseTime);
	
		GetComponent<SpringJoint2D> ().enabled = false;
		this.enabled = false;
		yield return new WaitForSeconds (2f);
		Destroy (player, 4f);
		if (nextBall != null) {
			nextBall.SetActive (true); 
		} else if (nextBall != null && enemy != 0) {
			SceneManager.LoadScene (0);
		}

	}
}
