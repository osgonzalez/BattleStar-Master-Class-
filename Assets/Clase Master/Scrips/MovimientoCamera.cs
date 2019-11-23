using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamera : MonoBehaviour {

	private GameObject player;

	private Vector3 distancia;

	void Start()
	{
		//Obtemenos el gameObject con el tag Player
		player=GameObject.FindGameObjectWithTag("Player");
		//Obtenemos la distancia a la que se halla originalmente la camara del jugador
		distancia = transform.position - player.transform.position;
	}

	void LateUpdate()
	{
		//Actualizamos la posicion de la camara
		transform.position = player.transform.position + distancia;
	}
}
