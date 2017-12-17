using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliders : MonoBehaviour {
	public GameObject cameraHandle;
	Animator cameraAnimator;

	public Slider sPhysfps;
	public Text   tPhysfps;

    public Slider sTs;
    public Text   tTs;

	public Slider sSpawnRate;
	public Text   tSpawnRate;

	public Slider sGrav;
	public Text   tGrav;

	public Slider sCamSpeed;
	public Text   tCamSpeed;

    // Use this for initialization
    void Start () {
		cameraAnimator = cameraHandle.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		tPhysfps.text = sPhysfps.value.ToString();
		tTs.text = sTs.value.ToString();
		tSpawnRate.text = sSpawnRate.value.ToString();
		tGrav.text = sGrav.value.ToString();
		tCamSpeed.text = sCamSpeed.value.ToString ();

		Time.timeScale = sTs.value;
		Time.fixedDeltaTime = (1f / sPhysfps.value) * Time.timeScale;
		Physics.gravity = new Vector3 (0f, -sGrav.value, 0f);
		cameraAnimator.speed = sCamSpeed.value;
	}
}