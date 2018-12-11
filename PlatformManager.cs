using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{


	public bool _use_vr = true;
	public GameObject DesktopPlayer;
	public GameObject VRPlayer;
	public GameObject StartButton;
	public GameObject JoinButton;

	void Awake ()
	{
		Debug.Log ("GameManager use_vr = " + _use_vr);
		UnityEngine.XR.XRSettings.enabled = _use_vr;
		DesktopPlayer.gameObject.SetActive (!UseVR ());
		VRPlayer.gameObject.SetActive (UseVR ());

		if (UseVR ()) {
			//show vr menu
			StartButton.gameObject.SetActive (UseVR ());
			JoinButton.gameObject.SetActive (!UseVR ());

		} else if (!UseVR ()) {
			//show desktop menu
			StartButton.gameObject.SetActive (!UseVR ());
			JoinButton.gameObject.SetActive (UseVR ());
		}
	}

	public bool UseVR ()
	{
		return _use_vr && UnityEngine.XR.XRDevice.isPresent;
	}
}
