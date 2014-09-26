using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerDatabase : MonoBehaviour {

	public List<Player> playerList = new List<Player>();
	public Player myPlayer;

	private const string defPlayerName = "Player";
	private const string defPlayerNation = "Space Marines";
	
	// Use this for initialization
	void Start () {
		playerList.Add(myPlayer);

		myPlayer.name = PlayerPrefs.HasKey("PlayerName") ? PlayerPrefs.GetString("PlayerName") : defPlayerName;
		myPlayer.nation = PlayerPrefs.HasKey("PlayerNation") ? PlayerPrefs.GetString("PlayerNation") : defPlayerNation;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
