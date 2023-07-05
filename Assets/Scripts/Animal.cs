using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class Animal : MonoBehaviour
{
    // ENCAPSULATION
    protected Rigidbody animal_rb;
    protected float jumpForce;
    protected float gravityModifier = 1f;
    protected bool isOnGround;

    protected Animator animal_anim;
    // ABSTRACTION
    public void StartAnimal()
    {
        animal_rb = GetComponent<Rigidbody>();
        animal_anim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier; 
        isOnGround = true;
    }
    // ABSTRACTION
    public virtual void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            animal_rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }
}
