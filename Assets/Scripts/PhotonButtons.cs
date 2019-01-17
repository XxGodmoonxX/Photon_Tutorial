using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotonButtons : MonoBehaviour {

	public menuLogic mLogic;

	public InputField joinRoomInput, createRoomInput;

	public void onClickCreateRoom() {
		if(createRoomInput.text.Length >= 1)
		PhotonNetwork.CreateRoom(createRoomInput.text, new RoomOptions() {MaxPlayers = 4}, null);
	}
	
	public void onClickJoinRoom() {
		PhotonNetwork.JoinRoom(joinRoomInput.text);
	}

	private void OnJoinedRoom() {
		mLogic.disableMenuUI();
		Debug.Log("Connected to Room");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
