using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyUp (KeyCode.Q))
		{
			Debug.Log ("QUIT!");
			Application.Quit ();
		}
		
	}
}
