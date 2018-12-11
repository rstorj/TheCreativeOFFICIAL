//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.Networking;
//using UnityEngine.UI;
//
//public class CustomNetworkUI : MonoBehaviour
//{
//	
//	public Text ipText;
//	public Text portText;
//	public GameObject[] playerPrefab;
//
//	public void start ()
//	{
//		
//	}
//
//	void Awake ()
//	{
//		Debug.Log ("Awake");
//	}
//
//	public void SelectPlayer ()
//	{
//		//maybe add this later? needs work
////		Dropdown drop = new Dropdown ();
////		drop.AddOptions ();
//
//		//Debug.Log ("Index for player select is" + i);
//		//if (playerPrefab != null && playerPrefabs [i] != null) {
//		//	NetworkManager.singleton.playerPrefab = playerPrefabs [i];
//		//}
//	}
//		public void StartServer ()
//		{
//			NetworkManager.singleton.StartHost ();
//	
//		}
//
//	public void startC ()
//	{
//		if (ipText.text.Length > 0 && ipText.text != null) {
//			NetworkManager.singleton.networkAddress = ipText.text;
//		}
//		if (portText.text.Length > 0 && portText.text != null) {
//			int x;
//			int.TryParse (portText.text, out x);
//			NetworkManager.singleton.networkPort = x;
//		}
//		NetworkManager.singleton.StartClient ();
//	}
//
//	public void startH ()
//	{
//		NetworkManager.singleton.StartHost (); //this starts a server and a client in the same application
//	}
//
//	//called second, this is our delegate
//	//public void specialSceneLoaded (Scene scene)
//	//	{
//	//	}
//
//
//	public void SetupDisconnectedMenu ()
//	{
//		
//	}
//
//	public void setupMenu ()
//	{
//		GameObject.Find ("ButtonStartServer").GetComponent<Button> ().onClick.RemoveAllListeners ();
//		GameObject.Find ("ButtonStartServer").GetComponent<Button> ().onClick.AddListener (startH);
//		GameObject.Find ("ButtonJointClient").GetComponent<Button> ().onClick.RemoveAllListeners ();
//		GameObject.Find ("ButtonJointClient").GetComponent<Button> ().onClick.AddListener (startC);
//		GameObject.Find ("DropDownPlayerSelect").GetComponent<Button> ().onClick.RemoveAllListeners ();
//
//
//
//		
//	}
//}
