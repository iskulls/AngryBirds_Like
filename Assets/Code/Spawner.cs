using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

	// Use this for initialization

	public Transform[] SpawnArea;
	public GameObject[] GameObjects;
	public GameObject[] ClonedObjects;

 
	void Start ()
	{
		spawner ();   
     
	}

	// Update is called once per frame
	void Update ()
	{

	}

	void spawner ()
	{
        
		ClonedObjects [0] = Instantiate (GameObjects [0], SpawnArea [0].transform.position, Quaternion.Euler (0, 0, 0)) as GameObject;
		ClonedObjects [1] = Instantiate (GameObjects [1], SpawnArea [1].transform.position, Quaternion.Euler (0, 0, 0)) as GameObject;
		ClonedObjects [2] = Instantiate (GameObjects [2], SpawnArea [2].transform.position, Quaternion.Euler (0, 0, 0)) as GameObject;
        

	}
}