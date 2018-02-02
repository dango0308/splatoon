using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAngle : MonoBehaviour {

	public float sensitivityX = 30F;
	public float sensitivityY = 30F;

	public float minimumX = -360F;
	public float maximumX = 360F;

	public float minimumY = -60F;
	public float maximumY = 60F;

	void Update ()
	{
			transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityX, 0);
	}

	void Start ()
	{
		// Make the rigid body not change rotation
		if (GetComponent<Rigidbody>())
			GetComponent<Rigidbody>().freezeRotation = true;
	}
}
