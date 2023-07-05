using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Fox : Animal
{
    // ENCAPSULATION
    private float foxJumpForce = 75f;
    private float foxAnimSpeed = 0.6f;
    // ABSTRACTION
    private void Start()
    {
        StartAnimal();
        animal_anim.SetFloat("Speed_f", foxAnimSpeed);
    }
    // POLYMORPHISM
    public override void Jump()
    {
        jumpForce = foxJumpForce;
        base.Jump();
    }
    private void Update()
    {
        Jump();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") == true)
        {
            isOnGround = true;
        }
    }
}
