using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoNetWork : MonoBehaviour {

	//SerializeFieldはPublicと似てるけどコードで書き換えられない、Unityのエディタ上のみ。
	[SerializeField]
  private string  m_resourcePath  = "";
  [SerializeField]
  private float   m_randomCircle  = 4.0f;

	private const string ROOM_NAME  = "RoomA";

	// Use this for initialization
	void Start () {
		PhotonNetwork.ConnectUsingSettings( null );
		Debug.Log("Start()");
	}

	void onJoinedLobby() {
		Debug.Log( "OnJoinedLobby()" );
		PhotonNetwork.JoinOrCreateRoom( ROOM_NAME, new RoomOptions(), TypedLobby.Default);
	}

	public void SpawnObject() {
		PhotonNetwork.Instantiate( m_resourcePath, GetRandomPosition(), Quaternion.identity, 0);
	}

	private Vector3 GetRandomPosition() {
		var rand = Random.insideUnitCircle * m_randomCircle;
		return rand;
	}

	// Update is called once per frame
	void Update () {
		// SpawnObject();
	}

	
}
