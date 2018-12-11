﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowScript : MonoBehaviour
{
	public GameObject flower1;
	public GameObject flower2;
	public GameObject flower3;
	public GameObject flower4;
	public GameObject flower5;
	public GameObject flower6;

	private Vector3 growSpot;

	private GameObject flower;

	public float timeLeft;
	private bool growMode = false;
	private bool active = true;

	private Material mat;

	public GameObject theLight;
	public GameObject p1;
	public GameObject p2;

	private Light lt;
	private ParticleSystem smolParticles;
	private ParticleSystem bigParticles;

	private float smolFLOAT;
	//maxium number of particles at start

	public GameObject[] Controls;
	private MeshRenderer[] controlsRender = new MeshRenderer[6];

	// Use this for initialization
	void Start ()
	{
		mat = gameObject.GetComponent<MeshRenderer> ().material;
		gameObject.GetComponent<MeshRenderer> ().material = mat;

		lt = theLight.GetComponent<Light> ();
		smolParticles = p1.GetComponent<ParticleSystem> ();
		bigParticles = p2.GetComponent < ParticleSystem> ();

		smolFLOAT = smolParticles.main.maxParticles; //maxium number of particles at start

		//set up all the control material references
		for (int i = 0; i < 6; i++) {
			controlsRender [i] = Controls [i].GetComponent<MeshRenderer> ();
		}

	



	}

	// Update is called once per frame
	void Update ()
	{

		if (growMode != true || active == false) {
			
			//fade the grow light
			Color newColor = mat.color;
			if (newColor.a >= 0.02) {
				newColor.a -= (Time.deltaTime / timeLeft);
				mat.color = newColor;
				gameObject.GetComponent<MeshRenderer> ().material = mat;
			}

			//Fade the controls
			Color newControlColor = controlsRender [1].material.color;
			if (newControlColor.a >= 0.02) {
				newControlColor.a -= (Time.deltaTime / timeLeft);
				for (int i = 0; i < 6; i++) {
					controlsRender [i].material.color = newControlColor;
				}

			}

			// set light intensity
			if (lt.intensity >= 0) {
				lt.intensity -= (Time.deltaTime / timeLeft) * 2.6f;
			}

			//fade particles
			var smolM = smolParticles.main;
			int smolMAX = smolM.maxParticles;
			if (smolMAX >= 10) {
				smolFLOAT -= (Time.deltaTime / timeLeft) * 800;
				smolMAX = Mathf.RoundToInt (smolFLOAT);
				smolM.maxParticles = smolMAX;


			} else {
				smolParticles.Stop ();
				bigParticles.Stop ();
			}

			//Debug.Log ("cone is: " + newColor.a + ", light is: " + lt.intensity + ", Particles stopped: " + smolParticles.isStopped + bigParticles.isStopped);
			if (mat.color.a <= 0.2 && lt.intensity <= 0 && smolParticles.isStopped == true && bigParticles.isStopped == true) {
				Expire ();
			}

		}
	}

	void OnTriggerEnter (Collider other)
	{
		if (growMode != true) {
			if (other.gameObject.name == "Palm") {
				Debug.Log ("wow a flower");
				//Debug.Log ("Here's where the flower grew: " + other.transform.position);
				GrowMode (true);
		

			}
		}
	}

	

	public void growThis (GameObject f)
	{
		if (growMode == true) {
			growSpot = this.transform.position;
			flower = f;
			GameObject sprout = Instantiate (flower) as GameObject;
			sprout.transform.position = growSpot;
			timeLeft = 3;
			GrowMode (false);
			active = false;
		}
	}

	void GrowMode (bool g)
	{
		growMode = g;
//		if (g == true) {
//			growSpot = this.transform.position;
//
//			int flowerNumber = (int)(Random.value * 10);
//
//			switch (flowerNumber) {
//			case 1:
//				flower = flower1;
//				break;
//			case 2:
//				flower = flower2;
//				break;
//			case 3:
//				flower = flower3;
//				break;
//			case 4:
//				flower = flower4;
//				break;
//			case 5:
//				flower = flower5;
//				break;
//			case 6:
//				flower = flower1;
//				break;
//			case 7:
//				flower = flower2;
//				break;
//			case 8:
//				flower = flower3;
//				break;
//			case 9: 
//				flower = flower4;
//				break;
//			case 10:
//				flower = flower5;
//				break;
//			default:
//				flower = flower6;
//				break;
//			}
//
//			GameObject sprout = Instantiate (flower) as GameObject;
//			sprout.transform.position = growSpot;
//			Expire ();
		
//		}
	}

	void Expire ()
	{
		Destroy (gameObject);
	}

}




