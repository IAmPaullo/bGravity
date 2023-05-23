using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player.Movement;
public class PlayerController : MonoBehaviour
{
    [SerializeField] PlayerMovement playerMovement;
    public Rigidbody2D rb;
    private bool canMove;



    private void FixedUpdate()
    {
        PlayerControlMovement();
    }

    private void PlayerControlMovement()
    {
        if (!canMove)
            return;
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        playerMovement.Move(moveX, moveY);
    }
}
