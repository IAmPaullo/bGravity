using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player.Movement
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] PlayerController controller;
        [SerializeField] private float moveSpeed = 5f;
        Rigidbody2D rb;
        private Vector2 movementDirection;

        private void Awake()
        {
            rb = controller.rb;
        }
        public void Move(float moveX, float moveY)
        {
            movementDirection = new Vector2(moveX, moveY).normalized;
            rb.velocity = movementDirection * moveSpeed;
        }

    }
}