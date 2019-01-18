using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonConnect : MonoBehaviour {

	public string versionName = "0.1";

	public GameObject sectionview1, sectionview2, sectionview3;

	// public void connectToPhoton() {
	private void Awake() {
		PhotonNetwork.ConnectUsingSettings(versionName);
		Debug.Log("Connecting to Photon...");
	}

	private void OnConnectedToMaster() {
		PhotonNetwork.JoinLobby(TypedLobby.Default);
		Debug.Log("Connected to master");
	}

	private void OnJoinedLobby() {
		sectionview1.SetActive(false);
		sectionview2.SetActive(true);
		Debug.Log("Joinde Lobby");
	}

	private void OnDisconnectFromPhoton() {
		if(sectionview1.active) {
			sectionview1.SetActive(false);
		}
		if(sectionview2.active) {
			sectionview1.SetActive(false);
		}
		sectionview3.SetActive(true);

		Debug.Log("Disconnect from photon");
	}
}
