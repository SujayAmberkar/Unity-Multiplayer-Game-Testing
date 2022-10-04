using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    public float minX;
    public float maxX;
    public float miny;
    public float maxY;

    private void Start() {
        //Spawn the player at a random location within the bounding coordinates
        Vector2 randomPosition = new Vector2(Random.Range(minX,maxX),Random.Range(miny,maxY));

        // Just like normal instantiate but this one make an instance on a multiplayer scene
        PhotonNetwork.Instantiate(playerPrefab.name,randomPosition,Quaternion.identity);    
    }
}
