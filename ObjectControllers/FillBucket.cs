using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillBucket : MonoBehaviour
{
	private bool filled;
	public GameObject bucketContents;

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.name == "WaterDrop(Clone)") {
			changeContents (true);
			Debug.Log ("fill 'er up");
		}
	}

	void OnTriggerExit (Collider other)
	{
		if (other.gameObject.name == "WaterDrop(Clone)") {
			changeContents (false);
			Debug.Log ("empty out");
			
		}
	}

	void changeContents (bool f)
	{
		bucketContents.SetActive (f);
		
	}
}
