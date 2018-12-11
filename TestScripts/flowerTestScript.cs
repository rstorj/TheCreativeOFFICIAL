using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowerTestScript : MonoBehaviour
{

	public GameObject testFlower;
	private Vector3[] spawnPoints;
	private int i = 0;
	private int limit = 100; //max number of flowers that can be spawned (Area)
	private int smolimit; //square root of max numbers (Side lengths)

	void Start ()
	{
		float FloLimit = (float)limit;
		if ((Mathf.Sqrt (FloLimit)) % 1 != 0) {
			Debug.Log ("Limit must be a square number");
			return;
		}
		smolimit = (int)Mathf.Sqrt (FloLimit);
		spawnPoints = new Vector3[limit];
		i = 0;
		int j = 0;
		int k = 0;

		for (j = 0; j < smolimit; j++) {
			for (k = 0; k < smolimit; k++) {
				if (i < limit) {
					spawnPoints [i] = new Vector3 (j, 0, k);
					i++;

				}


			}
		
		}
		i = 0;
	

	}
		

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown ("t")) {
			if (i < limit) {
				GameObject flower = Instantiate (testFlower) as GameObject;
				flower.transform.parent = GameObject.Find ("flowerholder").transform;
				flower.transform.localPosition = spawnPoints [i];
				Debug.Log (testFlower.name + " created");
				i++;
			} else {
				Debug.Log ("NO MORE FLOWERS");
			}
		}

		if (Input.GetKeyDown ("space")) {
			Destroy (GameObject.Find ("flowerholder"));
			GameObject flower = Instantiate (testFlower) as GameObject;
			flower.transform.parent = gameObject.transform;
			flower.transform.localPosition = new Vector3 (0, 0, 0);
		}

	}

	
}
