using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public ParticalManager PM;

	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Space)) 
		{
			Instantiate (PM.PlayerDie, transform.position, transform.rotation);
			Destroy (gameObject);
			Instantiate()())()()()(;
		}
	}
}
