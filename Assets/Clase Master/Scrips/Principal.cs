using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Principal : MonoBehaviour {

	public int score;

	// Use this for initialization
	void Start () {
		this.score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void addScore(int points){
		this.score += points;
		Debug.Log ("La puntuacion actual es: " + this.score);
	}
}
