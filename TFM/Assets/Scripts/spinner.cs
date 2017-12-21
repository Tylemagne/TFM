using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinner : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
        transform.Rotate(Vector3.up * Time.unscaledDeltaTime * 50f);
        transform.Rotate(Vector3.left * Time.unscaledDeltaTime * 22f);
        transform.Rotate(Vector3.forward * Time.unscaledDeltaTime * 11f);
    }
}
