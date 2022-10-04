using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    // connect to photon loadbalancing server
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings(); 
    }

    // Once connected to the server Join the lobby
    public override void OnConnectedToMaster(){ 
        PhotonNetwork.JoinLobby();
    }

    // Once the player joined the lobby load the create and join lobby scene
    public override void OnJoinedLobby()
    { 
        SceneManager.LoadScene("Lobby");
    }

    
}
