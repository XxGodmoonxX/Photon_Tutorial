using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class photonHandler : MonoBehaviour {

	public PhotonButtons photonB;

	private void Awake() {
		DontDestroyOnLoad(this.transform);
		SceneManager.sceneLoaded += OnSceneFinishedLoading;
	}

	public void createNewRoom() {
		PhotonNetwork.CreateRoom(photonB.createRoomInput.text, new RoomOptions() {MaxPlayers = 4}, null);
	}

	public void joinOrCreateRoom() {
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.MaxPlayers = 4;
		PhotonNetwork.JoinOrCreateRoom(photonB.joinRoomInput.text, roomOptions, TypedLobby.Default);
	}

	public void moveScene() {
		PhotonNetwork.LoadLevel("MainGame");
	}

	private void OnJoinedRoom() {
		// mLogic.disableMenuUI();
		moveScene();
		Debug.Log("Connected to Room");
	}

	private void OnSceneFinishedLoading(Scene scene, LoadSceneMode mode) {
		if(scene.name == "MainGame") {
			SpawnPlayer();
		}
	}

	private void SpawnPlayer() {
		PhotonNetwork.Instantiate(mainPlayer.name, mainPlayer.transform.position, mainPlayer.transform.rotation, 0);
	}
}
