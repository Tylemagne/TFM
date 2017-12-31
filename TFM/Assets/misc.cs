using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misc : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OpenGitHub()
	{
		Application.OpenURL ("http://github.com/Tylemagne/TFM");
	}

	public void OpenGitHubLatest()
	{
		Application.OpenURL ("http://github.com/Tylemagne/TFM/releases");
	}

	public void OpenGitHubCredits()
	{
		Application.OpenURL ("http://github.com/Tylemagne/TFM/blob/master/readme.md#credits");
	}
}
