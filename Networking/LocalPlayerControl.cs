using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using InputTracking = UnityEngine.XR.InputTracking;
using Node = UnityEngine.XR.XRNode;

public class LocalPlayerControl : NetworkBehaviour
{

	public GameObject ovrCamRig;
	public Transform leftHand;
	public Transform rightHand;
	public Camera head;
	Vector3 pos;
	public float speed = 3;

	// Use this for initialization
	void Start ()
	{
		pos = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!isLocalPlayer) {
			Destroy (ovrCamRig);
		} else {
			//take care of camera when other player joins
			if (head.tag != "MainCamera") {
				head.tag = "MainCamera";
				head.enabled = true;
			}

//			//take care of hand position tracking
//			leftHand.localRotation = InputTracking.GetLocalRotation (Node.LeftHand);
//			rightHand.localRotation = InputTracking.GetLocalRotation (Node.RightHand);
//			leftHand.localPosition = InputTracking.GetLocalPosition (Node.LeftHand);
//			rightHand.localPosition = InputTracking.GetLocalPosition (Node.RightHand);
//
//			//handle position and rotation of player
//		//	Vector2 primaryAxis = OVRInput.Get (OVRInput.Axis2D.PrimaryThumbstick);
//			if (primaryAxis.y > 0f) {
//				pos += (primaryAxis.y * transform.forward * Time.deltaTime * speed);
//			}
//			if (primaryAxis.y < 0f) {
//				pos += (Mathf.Abs (primaryAxis.y) * -transform.forward * Time.deltaTime * speed);
//			}
//			if (primaryAxis.x > 0f) {
//				pos += (primaryAxis.y * transform.right * Time.deltaTime * speed);
//			}
//			if (primaryAxis.x < 0f) {
//				pos += (Mathf.Abs (primaryAxis.y) * -transform.right * Time.deltaTime * speed);
//			}
//			transform.position = pos;
//
//			Vector3 euler = transform.rotation.eulerAngles;
//			Vector2 secondaryAxis = OVRInput.Get (OVRInput.Axis2D.SecondaryThumbstick);
//			euler.y += secondaryAxis.x;
//			transform.rotation = (Quaternion.Euler (euler));
//			//maybe set local rotation too
//			transform.localRotation = (Quaternion.Euler (euler));


		}
	}
}
