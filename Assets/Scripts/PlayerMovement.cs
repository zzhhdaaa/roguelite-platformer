using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D mRigidbody2D;

    public float horizontalMovementSpeed = 5f;
    public float jumpSpeed = 8f;

    public float jumpUpGravity = 3;
    public float fallDownGravity = 6;

    private void Start()
    {
        mRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.K) && mCollisionObjectCount > 0)
        {
            mRigidbody2D.velocity = new Vector2(mRigidbody2D.velocity.x, jumpSpeed);
        }

        mRigidbody2D.velocity = new Vector2(horizontal * horizontalMovementSpeed, mRigidbody2D.velocity.y);

        if (mRigidbody2D.velocity.y > 0)
        {
            mRigidbody2D.gravityScale = jumpUpGravity;
        }
        else
        {
            mRigidbody2D.gravityScale = fallDownGravity;
        }
    }

    public int mCollisionObjectCount = 0;

    private void OnCollisionEnter2D(Collision2D col)
    {
        mCollisionObjectCount++;
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        mCollisionObjectCount--;
    }
}
