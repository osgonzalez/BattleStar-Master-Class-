using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColor : MonoBehaviour {

	public float timeToChangeColor = 1;
	private float nextTimeChangeColor = 0;
	private Color [] colorList;
	private Renderer render;

	// Use this for initialization
	void Start () {
		colorList = new Color[]{
			new Color(200,200,200),
			new Color(255,0,0),
			new Color(0,255,0),
			new Color(0, 0, 255)};
		render = this.GetComponent<Renderer>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("1") && Time.time > nextTimeChangeColor)
		{
			render.material.color = colorList[1];
			nextTimeChangeColor = Time.time + timeToChangeColor;
			Debug.Log (render.material.color.ToString ());
		}
		if (Input.GetKey("2") && Time.time > nextTimeChangeColor)
		{
			render.material.color = colorList[2];
			nextTimeChangeColor = Time.time + timeToChangeColor;
			Debug.Log (render.material.color.ToString ());
		}
		if (Input.GetKey("3") && Time.time > nextTimeChangeColor)
		{
			render.material.color = colorList[3];
			nextTimeChangeColor = Time.time + timeToChangeColor;
			Debug.Log (render.material.color.ToString ());
		}
		if (Input.GetKey("4") && Time.time > nextTimeChangeColor)
		{
			render.material.color = colorList[0];
			nextTimeChangeColor = Time.time + timeToChangeColor;
			Debug.Log (render.material.color.ToString ());
		}
	}
}
