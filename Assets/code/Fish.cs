using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour {
	
	[SerializeField]
	private float _upwardForceMultiplier = 100f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		bool pressedFireButton = Input.GetButtonDown("Fire1");
		if (pressedFireButton)
		{
			Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
			rigidbody.velocity = Vector3.zero;
			rigidbody.AddForce(Vector3.up * _upwardForceMultiplier);
		}
	}
}
