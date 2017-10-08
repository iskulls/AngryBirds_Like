using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	private bool held = false;
	public Rigidbody2D rb;
	public float releaseTime = .1f;


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
		yield return new WaitForSeconds (releaseTime);

		GetComponent<SpringJoint2D> ().enabled = false;
		this.enabled = false;


	}
}
