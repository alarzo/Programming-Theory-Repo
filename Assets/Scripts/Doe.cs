using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Doe : Animal
{
    // ENCAPSULATION
    private float doeJumpForce = 250f;
    private float doeAnimSpeed = 0.8f;
    // ABSTRACTION
    private void Start()
    {
        StartAnimal();
        animal_anim.SetFloat("Speed_f", doeAnimSpeed);
    }
    // POLYMORPHISM
    public override void Jump()
    {
        jumpForce = doeJumpForce;
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
