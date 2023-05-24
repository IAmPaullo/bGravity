using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player.Movement;
public class PlayerController : MonoBehaviour
{
    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] SpriteRenderer playerSprite;
    public Rigidbody2D rb;
    [SerializeField] Animator playerAnimator;
    private bool canMove = true;
    private bool isDefaultSkin;
    [SerializeField] List<Sprite> skinListSprites = new();
    private int selectedSkin;


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
        playerAnimator.SetFloat("moveX", moveX);
        playerAnimator.SetFloat("moveY", moveY);
        if (moveX != 0 || moveY != 0)
            return;
        playerAnimator.SetBool("isCharacterMoving", false);
    }

    private void ChangePlayerSkin()
    {
        switch (selectedSkin)
        {
            case 0:
                //play particle effect
                playerSprite.sprite = skinListSprites[0];
                playerAnimator.SetInteger("playerSkin", selectedSkin);
                break;
        }
    }
}
