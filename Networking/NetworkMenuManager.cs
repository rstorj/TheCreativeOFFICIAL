using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class NetworkMenuManager : NetworkBehaviour
{
	public GameObject serverMenu;
	public Text serverIP;
	bool menuState = false;
	public GameObject quitButton;
	public GameObject mainMenuButton;

	public void StartServer ()
	{
		NetworkManager.singleton.StartHost ();
		serverMenu.SetActive (false);
		mainMenuButton.SetActive (false);
		quitButton.SetActive (true);
	}

	public void StartClient ()
	{
		getIP ();
		NetworkManager.singleton.StartClient ();
		serverMenu.SetActive (false);
		mainMenuButton.SetActive (false);
		quitButton.SetActive (true);
	}

	private void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) {
			menuState = !menuState;
			serverMenu.SetActive (menuState);
		}
	}

	public void getIP ()
	{
		if (serverIP.text.Length > 0 && serverIP.text != null) {
			NetworkManager.singleton.networkAddress = serverIP.text;
		}
	}
}