using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSer : MonoBehaviour {

	public Text fpsText;
	public float lastUpdate;

	// Use this for initialization
	void Start ()
	{
		//lastUpdate = Time.time;
		fpsText = gameObject.GetComponent<Text> ();
		//fpsText.text = "Measuring...";
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Time.time - lastUpdate > 0.2f)
		{
			float finalfloat = 1 / Time.deltaTime;
			int finalint = (int) finalfloat;
			fpsText.text = finalint.ToString();
			lastUpdate = Time.time;
		}
	}
}