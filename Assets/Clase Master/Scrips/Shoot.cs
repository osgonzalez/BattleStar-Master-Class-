﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {


	public float shootVelocity = 1000;
	public int damage = 10;
	// Use this for initialization
	void Start () {
		Rigidbody rb = this.GetComponent<Rigidbody>();
		rb.AddForce(this.transform.up * shootVelocity);

	}

	// Update is called once per frame
	void Update () {

	}

	private void OnCollisionEnter(Collision collision)
	{
		Vida script = collision.gameObject.GetComponent<Vida>();
		if (script != null)
		{
			script.doDamage(damage);
		}
		Destroy(this.gameObject);
	}
}
