using UnityEngine;
using VRTK;

public class MenuToggle : MonoBehaviour
{
	public VRTK_ControllerEvents controllerEvents;
	public GameObject menu;
	bool menuState = false;

	void onEnable ()
	{
		controllerEvents.ButtonTwoPressed += ControllerEvents_ButtonTwoPressed;
		controllerEvents.TriggerPressed += ControllerEvents_ButtonTwoPressed;
	}

	void onDisable ()
	{
		controllerEvents.ButtonTwoPressed -= ControllerEvents_ButtonTwoPressed;
	}

	void ControllerEvents_ButtonTwoPressed (object sender, ControllerInteractionEventArgs e)
	{
		//menuState = !menuState;
		Debug.Log (menuState);
		//menu.SetActive (menuState);
		//turn off movement
//		GetComponent<VRTK_TouchpadControl> ().enabled = (!menuState);
//		//turn on menu controls
//		GetComponent<VRTK_StraightPointerRenderer> ().enabled = (menuState);
//		GetComponent<VRTK_UIPointer> ().enabled = (menuState);
//		GetComponent<VRTK_Pointer> ().enabled = (menuState);
	}
		
}
