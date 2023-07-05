using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Horse : Animal
{
    // ENCAPSULATION
    private float horseJumpForce = 575f;
    private float horseAnimSpeed = 1.2f;
    // ABSTRACTION
    private void Start()
    {
        StartAnimal();
        animal_anim.SetFloat("Speed_f", horseAnimSpeed);
    }
    // POLYMORPHISM
    public override void Jump()
    {
        jumpForce = horseJumpForce;
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
