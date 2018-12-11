using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class Tree : MonoBehaviour
{
	private UAI_Agent TreeBrains;

	private Land LandScript;

	// Use this for initialization
	void Start ()
	{
		TreeBrains = GetComponent<UAI_Agent> ();
		TreeBrains.SetVoidActionDelegate ("Heal", Heal);
		TreeBrains.SetVoidActionDelegate ("InfluencePlants", InfluencePlants);
		TreeBrains.SetVoidActionDelegate ("SpawnCritters", SpawnCritters);

		LandScript = GameObject.Find ("Terrain_0_0-20181102-101609").GetComponent<Land> ();

	}
	
	// Update is called once per frame
	void Update ()
	{
		TreeBrains.UpdateAI ();
	}

	void Heal ()
	{
		//Make terrain more green
		LandScript.Heal ();

		//also heal self
	}

	void InfluencePlants ()
	{
		
	}

	void SpawnCritters ()
	{
		
	}
}
