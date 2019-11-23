using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour {

	private Rigidbody rb;
	public float speed=1;
	public float rotateSpeed = 1;



	// Use this for initialization
	void Start () {
		this.rb = this.GetComponent<Rigidbody>();
		//rb.freezeRotation = true;
		//rb.useGravity = false;

	}
	
	// Update is called once per frame
	void Update () {
		
		//Recoje el valor del imput horizontal y vertical y devielve un valor entre [-1,1]
		float movHor= Input.GetAxis("Horizontal");
		float movVer = Input.GetAxis("Vertical");

		//rb.AddForce((new Vector3(movHor, 0, movVer)) * speed * Time.deltaTime);
		this.rb.velocity =(new Vector3(movHor, 0, movVer)) * speed ;


		if (Input.GetKey("l"))
		{
			rb.rotation = Quaternion.Euler((rb.rotation.eulerAngles + new Vector3(0, rotateSpeed, 0)));
		}

		if (Input.GetKey("k"))
		{
			rb.rotation = Quaternion.Euler((rb.rotation.eulerAngles + new Vector3(0, -rotateSpeed, 0)));
		}

	}
}
