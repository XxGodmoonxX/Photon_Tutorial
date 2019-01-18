using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotonButtons : MonoBehaviour {

	// public menuLogic mLogic;
	public photonHandler pHandler;

	public InputField joinRoomInput, createRoomInput;

	public void onClickCreateRoom() {
		// if(createRoomInput.text.Length >= 1)
		// PhotonNetwork.CreateRoom(createRoomInput.text, new RoomOptions() {MaxPlayers = 4}, null);

		pHandler.createNewRoom();
	}
	
	public void onClickJoinRoom() {
		// // PhotonNetwork.JoinRoom(joinRoomInput.text);
		// RoomOptions roomOptions = new RoomOptions();
		// roomOptions.MaxPlayers = 4;
		// PhotonNetwork.JoinOrCreateRoom(joinRoomInput.text, roomOptions, TypedLobby.Default);

		pHandler.joinOrCreateRoom();
	}

	// private void OnJoinedRoom() {
	// 	// mLogic.disableMenuUI();
	// 	pHandler.moveScene();
	// 	Debug.Log("Connected to Room");
	// }
}
