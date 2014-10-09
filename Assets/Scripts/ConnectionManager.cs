using UnityEngine;
using System.Collections;

public class ConnectionManager : MonoBehaviour {

	//Used to store a relation to the MenuManager script
	private MenuManager menuManager;

	private LevelManager levelManager;

	// Use this for initialization
	void Start () {
		menuManager = GameObject.Find("Menu").GetComponent<MenuManager>();
		levelManager = GameObject.Find ("LevelManager").GetComponent<LevelManager>();
	}

	//Fires when the player or the server disconnects from the network
	void OnDisconnectedFromServer ()
	{
		levelManager.PlayerHasDisconnected();

		//Switch the menu back
		menuManager.NavigateTo("Main");
		
	}

	public void ConnectToServer(string ip, int port){
		Network.Connect(ip, port);
	}

	void OnConnectedToServer(){
		Debug.Log ("Connected");
		menuManager.NavigateTo("Server Lobby");
	}
}
