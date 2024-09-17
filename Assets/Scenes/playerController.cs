using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour

{
    Rigidbody2D playerObject;

    public float speed = 5;

    public float jumpHeight = 15;

    void Start()
    {
        playerObject = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movementValueX = Input.GetAxis("Horizontal");
        float movementValueY = Input.GetAxis("Vertical");
        playerObject.velocity = new Vector2(movementValueX * speed, playerObject.velocity.y);
        playerObject.velocity = new Vector3(playerObject.velocity.x, movementValueY * jumpHeight);
        
            
    }
}
