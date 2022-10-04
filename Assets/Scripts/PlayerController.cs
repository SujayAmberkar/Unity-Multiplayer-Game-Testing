using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Photon.Pun;

public class PlayerController : MonoBehaviour
{
    public Vector2 moveVal;
    public float speed = 10f;
    Rigidbody2D rbd;
    PhotonView view;

    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        Movements();
    }

    void OnMove(InputValue value){
        moveVal = value.Get<Vector2>();
    }
    void Movements(){
        if(view.IsMine){
            Vector2 playerVelocity = new Vector2(moveVal.x*speed,moveVal.y*speed);
            rbd.velocity = playerVelocity;
            bool playerHasHorizontalSpeed = Mathf.Abs(rbd.velocity.x) > 0;
        }
        
        
    }
}
