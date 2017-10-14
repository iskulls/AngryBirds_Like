using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnCollisionEnter2D (Collision2D colInfo)
	{
		if (colInfo.gameObject.tag == "Player") {
			Destroy (this.gameObject);
		}
			
	}

}
