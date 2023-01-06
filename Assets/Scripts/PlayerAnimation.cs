using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Rigidbody2D mRigidbody2D;

    private PlayerMovement mPlayerMovement;
    
    private void Awake()
    {
        mRigidbody2D = GetComponent<Rigidbody2D>();
        mPlayerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        var velocity = mRigidbody2D.velocity;

        var scale = new Vector3(1f + 0.2f * Mathf.Abs(velocity.x / mPlayerMovement.horizontalMovementSpeed), 1f, 1f);

        transform.localScale = scale;

    }
}
