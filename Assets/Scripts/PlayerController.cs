using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public bool grounded;
    public LayerMask whatIsGround;

    private Rigidbody2D _myRigidbody2D;
    private Collider2D _myCollider;
         
    void Start()
    {
        _myRigidbody2D = GetComponent<Rigidbody2D>();
        _myCollider = GetComponent<Collider2D>();
    }

   
    void Update()
    {
        grounded = Physics2D.IsTouchingLayers(_myCollider, whatIsGround);

        _myRigidbody2D.velocity = new Vector2(moveSpeed, _myRigidbody2D.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (grounded)
            {
                _myRigidbody2D.velocity = new Vector2(_myRigidbody2D.velocity.x, jumpForce);
            }
        }
    }
}
