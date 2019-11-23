using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoJugador : MonoBehaviour {

	public GameObject shoot;
	public float shootDurationTime = 1.7f;
	public float shootCadence = 0.5f;
	private float nextTimeForShoot = 0;

	private GameObject shootInstance;		//Gloval variable for memory eficicence (Solo en caso de shootDurationTime > shootCadence)
	public GameObject shootBase;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("space") && nextTimeForShoot<Time.time)
		{
			nextTimeForShoot = Time.time + shootCadence;

			shootInstance = Instantiate(shoot, (shootBase.transform.position + (this.transform.forward * 1)),shootBase.transform.rotation);
			Destroy (shootInstance, shootDurationTime);

		}
		
	}
}
