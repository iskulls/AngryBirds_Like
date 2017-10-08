using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud_1Movement : MonoBehaviour
{

	private Rigidbody rb;

	float timeframe;

	// Use this for initialization
	void Start ()
	{
        
	}

	// for the movemtent i could not fix the curly brackets
	void Update ()
	{
		transform.Translate (-0.002f, 0, 0);
		timeframe += Time.deltaTime;
		if (timeframe >= 80) {
			Destroy (this.gameObject);
		}
	}
}

