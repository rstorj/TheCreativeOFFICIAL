using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeServerOpts : MonoBehaviour
{
	public Dropdown serverOpt;
	public GameObject hostServ;
	public GameObject joinServ;

	public void onValueChanged (int dropDownOpt)
	{
		dropDownOpt = serverOpt.value;

		switch (dropDownOpt) {
		case 0:
			hostServ.SetActive (true);
			joinServ.SetActive (false);
			break;
		case 1:
			hostServ.SetActive (false);
			joinServ.SetActive (true);
			break;
		}

	}
}
