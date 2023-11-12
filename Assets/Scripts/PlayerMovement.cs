using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb2d;

    Vector2 moveInput;

    [SerializeField] float runSpeed = 1f;

    void Start()
    {
       rb2d = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Run();
        FlipSprite();
    }

    void Run()
    {
        Vector2 playerVelocity = new Vector2(moveInput.x * runSpeed, rb2d.velocity.y);
        rb2d.velocity = playerVelocity;
    }

    void FlipSprite()
    {
        bool playerHasHorizontalLook = Mathf.Abs(rb2d.velocity.x) > Mathf.Epsilon;

        if(playerHasHorizontalLook)
        {
            transform.localScale = new Vector2(Mathf.Sign(rb2d.velocity.x),1f);
        }
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        Debug.Log(moveInput);
    }
}
