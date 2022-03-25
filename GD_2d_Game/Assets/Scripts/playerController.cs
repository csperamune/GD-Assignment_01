using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;
    public ParticleSystem dust;

    private Rigidbody2D rb;

    private bool facingRight = true;
    
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask WhatIsGround;

    private int extraJump;
    public int extraJumpVal;

    void Start()
    {
        extraJump = extraJumpVal;
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, WhatIsGround);


        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (facingRight == false && moveInput > 0)
        {
            flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            flip();
        }
    }

    void Update()
    {
        if (isGrounded == true)
        {
            extraJump = extraJumpVal;


            if (Input.GetKeyDown(KeyCode.Space) && extraJump > 0)
            {
                createDust();
                rb.velocity = Vector2.up * jumpForce;
                extraJump--;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && extraJump == 0 && isGrounded == true)
            {
                createDust();
                rb.velocity = Vector2.up * jumpForce;
            }
        }
    }

    void flip()
    {
        createDust();
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    void createDust()
    {
        dust.Play();
    }
}
