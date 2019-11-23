﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liveScript : MonoBehaviour {

    public int life = 100;
	public int colorType =0;
	public int score = 0; 
	public GameObject wall;
	private wallScript wScript;
	private bool wallIsNotSeted = true;
	private levelmainScript main; 

    // Use this for initialization
    void Start () {
		if (wall != null && wallIsNotSeted) {
			wallIsNotSeted = false;
			wScript = wall.GetComponent<wallScript> ();
			wScript.addEnemyForOpen ();

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void setWall(GameObject wall){
		this.wall = wall;
		if (wall != null && wallIsNotSeted) {
			wallIsNotSeted = false;
			wScript = wall.GetComponent<wallScript> ();
			wScript.addEnemyForOpen ();

		}
	}

    public void doDamage(int damage)
    {
        this.life -= damage;
        if (life <= 0)
        {
			if (score > 0) {
				main = GameObject.FindGameObjectWithTag ("Main").GetComponent<levelmainScript>();
				main.addScore (score);
			}
			if (wall != null) {
				wScript.removeEnemyForOpen ();
			}
            Destroy(this.gameObject);
        }
    }
}
