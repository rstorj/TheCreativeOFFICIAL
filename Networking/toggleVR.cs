//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//
//public class toggleVR : MonoBehaviour
//{
//
//	private int frameNumberSwitched = -10;
//	private const int numberOfFramesToSwitchToVrInUnity = 2;
//	private bool currentlyVRenabled = false;
//
//	void Update ()
//	{
//		if ((Time.frameCount - frameNumberSwitched == numberOfFramesToSwitchToVrInUnity) && UnityEngine.XR.XRDevice.isPresent) {
//			UnityEngine.XR.XRSettings.enabled = true;
//			return;
//		}
//
//		if ((Time.frameCount - frameNumberSwitched == numberOfFramesToSwitchToVrInUnity) && !UnityEngine.XR.XRDevice.isPresent) {
//			UnityEngine.XR.XRSettings.LoadDeviceByName ("None");
//			return;
//		}
//
//		if (Input.GetKeyDown (KeyCode.Space)) {
//			if (!currentlyVRenabled) {
//				UnityEngine.XR.XRSettings.LoadDeviceByName ("OpenVR");
//				currentlyVRenabled = true;
//			} else {
//				UnityEngine.XR.XRSettings.LoadDeviceByName ("None");
//				currentlyVRenabled = false;
//			}
//
//			frameNumberSwitched = Time.frameCount;
//		}
//	}
//}
