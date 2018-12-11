using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeLight : MonoBehaviour
{
	public GameObject LightBeam;
	private Vector3 lightSpot;
	public Terrain myTerrain;

	//CREATES SPOT OF LIGHT ON TERRAIN
	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.name == "WaterDrop(Clone)") {
			lightSpot = other.transform.position;
			Destroy (other.gameObject);

			GameObject light = Instantiate (LightBeam) as GameObject;
			light.transform.position = lightSpot;
		}
	}
}







