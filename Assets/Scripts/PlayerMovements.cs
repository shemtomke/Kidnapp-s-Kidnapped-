using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public float speed = 2f;
    public Animator animator;
    private float turningAngle = 30;
   
    
    
    private void Update()
    {
        float animSpeed = 0;
        var velocity = Vector3.forward * Input.GetAxis("Vertical") * speed;
        transform.Translate(velocity * Time.deltaTime);
        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * Time.deltaTime * turningAngle);

        if (velocity.z > 0.1)
        {
            animSpeed = 1;
        }
        else if (velocity.z < -0.1)
        {
            animSpeed = -1;
        }
        else
        {
            animSpeed = 0;
        }
        animator.SetFloat("Speed", animSpeed);

        Movements();
        
        
    }

    public void Movements()
    {
        if (animator != null)
        {
            if (Input.GetKey(KeyCode.J))
            {
                animator.SetTrigger("Jump");
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                animator.SetTrigger("RFowards");
            }
            if (Input.GetKey(KeyCode.B))
            {
                animator.SetTrigger("RunBackwards");
            }
            if (Input.GetKey(KeyCode.G))
            {
                animator.SetTrigger("Gather");
            }
        }
        
    }

   

}
