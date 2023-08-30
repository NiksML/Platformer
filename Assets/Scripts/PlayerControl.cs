using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public static PlayerControl instance;
    private float speed = 5f;
    private float powerJump = 10f;
    private Rigidbody2D rb;
    private bool isGrounded;
    
    private void Awake()
    {
        instance = this;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {

    }

    private void Flip()
    {

    }

    private void Moving()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }

    private void Jump()
    {
        if(isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * powerJump, ForceMode2D.Impulse);
        }
    }

    private void CheckGround()
    {
        var groundCheck = transform.GetChild(0);
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.position, 0.2f);
        isGrounded = colliders.Length > 1;
    }

    private void Update()
    {
        Moving();
        CheckGround();
        Jump();
    }

    private void FixedUpdate()
    {
        
    }
}
