using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class benchmaster : MonoBehaviour {

	public Slider[] sliders;
	public Texture none;
	public Canvas dash;
	public AudioSource music;
	public Canvas cancel;
	public int score;
	public bool isBenchmarking;
	public float duration;
	public float benchStartedTime;
	public Canvas scoreCanvas;
	public Text scoreCanvasText;


	public void setAllSliders(bool state) //lock or unlock
	{
		for(int x = 0; x < sliders.Length; x++)
		{
			sliders[x].interactable = state;
		}

		sliders [6].value = 0.05f;
		sliders [6].interactable = true;



		cancel.enabled = true; //show cancel button
	}
		

	public void startBenchmarkAny()
	{
		music.Stop ();
		music.Play ();

		isBenchmarking = true;
		setAllSliders (false);
		dash.enabled = false;
		score = 0;
		benchStartedTime = Time.unscaledTime;
	}

	public void calibrateSliders(float cam, int globalfps, float grav, int physfps, int spawn, float times)
	{
		sliders [0].value = cam;
		sliders [1].value = globalfps;
		sliders [2].value = grav;
		sliders [3].value = physfps;
		sliders [4].value = spawn;
		sliders [5].value = times;

	}

	public void calibrateSlidersSet(int set)
	{
		if(set == 1) calibrateSliders (0.5f, 145, 1.21f, 60, 1, 0.5f); //light
		if(set == 2) calibrateSliders (1f, 145, 9.81f, 75, 3, 1f); //moderate
		if(set == 3) calibrateSliders (5f, 145, 25f, 144, 35, 2f); //extreme
		if(set == 4) calibrateSliders (0.1f, 145, 1.21f, 144, 8, 1f); //relaxed
		if(set == 5) calibrateSliders (1f, 145, 9.81f, 144, 5, 0.1f); //slomo
		if(set == 6) calibrateSliders (0f, 145, 9.81f, 7, 6, 0.5f); //dualfps

		if (dash.enabled)
		{
			dash.enabled = false;
		}

		GameObject[] spheres = GameObject.FindGameObjectsWithTag ("TFMSphere");

		foreach(GameObject sphere in spheres)
		{
			DestroyImmediate (sphere);
		}

		spheres = null;
	}

	public void startBenchmark1()
	{
		calibrateSlidersSet (1);
		startBenchmarkAny ();

	}

	public void startBenchmark2()
	{
		calibrateSlidersSet (2);
		startBenchmarkAny ();
	}

	public void startBenchmark3()
	{
		calibrateSlidersSet (3);
		startBenchmarkAny ();
	}

	public void cancelBenchmark()
	{
		stopBenchmark ();
		scoreCanvas.enabled = false;
	}

	public void stopBenchmark()
	{
		isBenchmarking = false;
		int avg = score / (int)duration;
		Debug.Log ("final score: "+score.ToString()+" avg: "+avg.ToString());
		scoreCanvasText.text = score.ToString();
		score = 0;
		setAllSliders (true);
		cancel.enabled = false;
		scoreCanvas.enabled = true;
		dash.enabled = false;
	}

	public void closeScoreWindow()
	{
		scoreCanvas.enabled = false;
	}

	// Use this for initialization
	void Start () {

		//duration = 60f;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (isBenchmarking)
		{
			score++;
		}

		if (isBenchmarking && Time.unscaledTime - benchStartedTime >= duration)
		{
			
			stopBenchmark ();
		}


		
	}
}
