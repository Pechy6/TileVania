using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float runSpeed = 1f;

    Rigidbody2D myRigidbody;

    Vector2 moveInput;

    Animator myAnimator;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
    }


    void Update()
    {
        Run();
        FlipSprite();
    }

    void Run()
    {
        Vector2 playerVelocity = new Vector2(moveInput.x * runSpeed, myRigidbody.velocity.y);
        myRigidbody.velocity = playerVelocity;

        
    }

    void FlipSprite()
    {
        bool playerHasHorizontalLook = Mathf.Abs(myRigidbody.velocity.x) > Mathf.Epsilon;

        if(playerHasHorizontalLook)
        {
            transform.localScale = new Vector2(Mathf.Sign(myRigidbody.velocity.x),1f);
        }
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        Debug.Log(moveInput);
    }
}
