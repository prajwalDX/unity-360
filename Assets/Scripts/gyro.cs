using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	public class gyro : MonoBehaviour {

	void Awake () {
		// Check gyro works on this device:
		if (!SystemInfo.supportsGyroscope) {
			Debug.Log ("WARNING: Gyro not supported");
			if (Application.platform != RuntimePlatform.IPhonePlayer ||
				Application.platform != RuntimePlatform.Android) {
				Debug.Log ("WARNING: Gyro only works on phone");
			}
		}

		Input.gyro.enabled = true;    // Enable gyro.
	}

	void Update () {
		
		Quaternion transQuat = new Quaternion(Input.gyro.attitude.x, Input.gyro.attitude.y,
			-Input.gyro.attitude.z, -Input.gyro.attitude.w);
		gameObject.transform.rotation = Quaternion.Euler (90, 0, 0) * transQuat;
		Debug.Log ("transQuat = " + transQuat.eulerAngles.ToString());
	}
}