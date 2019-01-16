using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoNetWork : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PhotonNetwork.ConnectUsingSettings( null );
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onJoinedLobby() {
		Debug.Log( "OnJoinedLobby()" );
	}
}
