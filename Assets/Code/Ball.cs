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
	public GameObject slingShot;

	Vector3 Mp;

	void Update ()
	{   
		Mp = Camera.main.ScreenToWorldPoint (Input.mousePosition);

		if (held) {
			float x = Mathf.Clamp (Mp.x, slingShot.transform.position.x - 3, slingShot.transform.position.x + 3);
			float y = Mathf.Clamp (Mp.y, slingShot.transform.position.y - 3, slingShot.transform.position.y + 3);
			float z = Mathf.Clamp (Mp.z, slingShot.transform.position.z - 3, slingShot.transform.position.z + 3);

			rb.position = new Vector3(x, y, z); 

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
		yield return new WaitForSeconds (4f);
		Destroy (player, 6f);
		if (nextBall != null) {
			nextBall.SetActive (true); 
		} else if (enemy != 0) {
			SceneManager.LoadScene (1);
		}

	}
}
