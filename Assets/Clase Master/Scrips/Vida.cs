using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour {


	public int life = 100;
	public int score = 500;
	public Principal principal;

	// Use this for initialization
	void Start () {
		this.principal = GameObject.FindGameObjectWithTag ("Main").GetComponent<Principal>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void doDamage(int damage)
	{
		this.life -= damage;
		if (life <= 0)
		{
			if (score > 0) {
				principal.addScore(score);
			}

			Destroy(this.gameObject);
		}
	}
}
