﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{


	public float moveSpeed;
	private float maxSpeed = 5f;
	private Vector3 input;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
		if (GetComponent<Rigidbody>().velocity.magnitude < maxSpeed) 
		{
			GetComponent<Rigidbody>().AddForce (input * moveSpeed);	
		}

		print (input);

	}
}
