using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dtoggle : MonoBehaviour {

	public Canvas canvas;
	public int score;

	// Use this for initialization
	void Start () {

		canvas = gameObject.GetComponent<Canvas> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		score++;

		if (Input.GetKeyUp(KeyCode.D))
		{
			canvas.enabled = !canvas.enabled;
		}
		
	}
}
