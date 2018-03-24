using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabrinthMovement : MonoBehaviour 
{
	private Transform labr;
	private float tempX, tempZ;
	void Start () 
	{
		labr = GetComponent<Transform>();
		tempX = labr.rotation.eulerAngles.x;
		tempZ = labr.rotation.eulerAngles.z;
	}

	void Update () 
	{
		int limit = 45;
		if(Input.GetKey(KeyCode.W))//x axis positive
		{			
			if(tempX < limit)
				tempX ++;
			if(tempX > limit)
				tempX = limit;
		}
		if(Input.GetKey(KeyCode.S))//x axis negative
		{			
			if(tempX > -limit)
				tempX --;
			if(tempX < -limit)
				tempX = limit;
		}
		if(Input.GetKey(KeyCode.A))//z axis positive
		{
			if(tempZ < limit)
				tempZ ++;
			if(tempZ > limit)
				tempZ = limit;
		}
		if(Input.GetKey(KeyCode.D))//z axis negative
		{			
			if(tempZ > -limit)
				tempZ --;
			if(tempZ < -limit)
				tempZ = limit;
		}
		Quaternion newAngle = Quaternion.Euler(tempX, 0f, tempZ);
		labr.rotation = Quaternion.Slerp(labr.rotation, newAngle, Time.time);
	}
}
