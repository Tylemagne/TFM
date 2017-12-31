using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hwinfo : MonoBehaviour {

	public Text cpu;
	public Text gpu;
	public Text ram;
	public Text api;

	// Use this for initialization
	void Start () {

		cpu.text = SystemInfo.processorType;
		gpu.text = SystemInfo.graphicsDeviceName;
		ram.text = SystemInfo.systemMemorySize.ToString()+"MB";
		api.text = SystemInfo.graphicsDeviceType.ToString();


		//Debug.Log (SystemInfo.graphicsDeviceType);
		Debug.Log ("NAME "+SystemInfo.graphicsDeviceName);

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
