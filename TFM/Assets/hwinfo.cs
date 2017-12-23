using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hwinfo : MonoBehaviour {

	public Text gpu2;

	// Use this for initialization
	void Start () {

		//Debug.Log (SystemInfo.graphicsDeviceType);
		Debug.Log ("NAME "+SystemInfo.graphicsDeviceName);
		gpu2.text = SystemInfo.graphicsDeviceName;
		Debug.Log ("DID "+ SystemInfo.graphicsDeviceID);
		Debug.Log (SystemInfo.graphicsDeviceType);
		Debug.Log (SystemInfo.graphicsDeviceVendor);
		Debug.Log (SystemInfo.graphicsDeviceVendorID);
		Debug.Log (SystemInfo.graphicsDeviceVersion);
		Debug.Log (SystemInfo.graphicsMemorySize);
		Debug.Log (SystemInfo.graphicsMultiThreaded);
		Debug.Log (SystemInfo.graphicsShaderLevel);

		Debug.Log (SystemInfo.deviceModel);
		Debug.Log (SystemInfo.deviceName);
		Debug.Log (SystemInfo.deviceType);
		Debug.Log (SystemInfo.deviceUniqueIdentifier);

		Debug.Log (SystemInfo.processorCount);
		Debug.Log (SystemInfo.processorFrequency);
		Debug.Log (SystemInfo.processorType);

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
