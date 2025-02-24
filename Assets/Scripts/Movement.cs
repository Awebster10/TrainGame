using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   public float MoveSpeed = 5f;

   public Rigidbody2D rb;
   public Animator Animator;

   Vector2 PlayerMovement;

   void Update()
   {
      PlayerMovement.x = Input.GetAxisRaw("Horizontal");
      PlayerMovement.y = Input.GetAxisRaw("Vertical");

      Animator.SetFloat("Horizontal", PlayerMovement.x);
      Animator.SetFloat("Vertical", PlayerMovement.y);
      Animator.SetFloat("Speed", PlayerMovement.sqrMagnitude);
   }

   void FixedUpdate()
   {
      rb.MovePosition(rb.position + PlayerMovement * MoveSpeed * Time.fixedDeltaTime);
   }


}
