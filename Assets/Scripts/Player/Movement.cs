using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRigidbody;
    [SerializeField] private float playerMovementSpeed;
    [SerializeField] private float playerJumpHeight;

    private void Update()
    {
        PlayerMovement();
        PlayerJump();
    }

    private void PlayerMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        playerRigidbody.velocity = new Vector2(horizontalInput * playerMovementSpeed, playerRigidbody.velocity.y);
    }

    private void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRigidbody.velocity = new Vector2(playerRigidbody.velocity.x, playerJumpHeight);
        }
    }
    
}
