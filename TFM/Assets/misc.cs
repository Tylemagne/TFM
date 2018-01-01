using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misc : MonoBehaviour {

	public Canvas dashboard;
	public Canvas m_api;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CloseAPIPopup()
	{
		m_api.enabled = false;
	}

	public void OpenAPIPopup()
	{
		dashboard.enabled = false;
		m_api.enabled = true;
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
