using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnRB : MonoBehaviour
{
	public GameObject ball;
    public Slider spawnRateSlider;
	public float fForceVariance;

	// Use this for initialization
	void Start ()
	{
		Time.timeScale = 1f;
		Time.fixedDeltaTime = (1f / 144f) * Time.timeScale;

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Random.Range (1, 50) < spawnRateSlider.value)
		{
			GameObject ballClone = Instantiate (ball) as GameObject;
			Renderer ballRenderer = ballClone.GetComponent<Renderer> ();
			Rigidbody ballRigid = ballClone.GetComponent<Rigidbody> ();

			Color me = new Color (Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0.5f,0.9f));

			ballRenderer.material.SetColor ("_Color", me);
			

            float randomSize = Random.Range(-0.5f, 1.5f);
			ballClone.transform.position += new Vector3(Random.Range(-5f, 5f),Random.Range(-5f, 5f),Random.Range(-5f, 5f));
            ballClone.transform.localScale += new Vector3(randomSize,randomSize,randomSize);

			ballRigid.AddForce(
				new Vector3 (
				Random.Range(-fForceVariance,fForceVariance),
				Random.Range(-fForceVariance,fForceVariance),
				Random.Range(-fForceVariance,fForceVariance))
			);

			Destroy (ballClone, 16f);
		}
	}
}
