using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DSCFPSP.Control
{
    public class FirstPersonMovement : MonoBehaviour
    {

        [SerializeField]
        private float speed = 10f;
        [SerializeField]
        private float jumpForce = 2f;
        [SerializeField]
        private float gravity = -1f;

        private Rigidbody rigidbody;
        private CharacterController playerController;

        private Vector3 moveDirection = Vector3.zero;

        // Start is called before the first frame update
        void Start()
        {
            rigidbody = GetComponent<Rigidbody>();
            playerController = GetComponent<CharacterController>();
        }

        // Update is called once per frame
        void Update()
        {
            if(playerController.isGrounded)
            {
                HandleMovement();
                HandleJump();
            }else
            {
                ApplyGravity();
            }
            ApplyMovement();
        }


        //=====>MOVEMENT && JUMP<=====//
        //MOVE MOTOR
        private void ApplyMovement()
        {
            playerController.Move(moveDirection);
        }
        //GRAVITY
        private void ApplyGravity()
        {
            moveDirection.y += gravity * Time.deltaTime;
        }

        //MOVEMENT SECTION
        private void HandleMovement()
        {
            float inputX = Input.GetAxis("Horizontal");
            float inputY = Input.GetAxis("Vertical");

            moveDirection = (Vector3.right * inputX + Vector3.forward * inputY) * speed * Time.deltaTime;
        }
        //Jump trigger
        private void HandleJump()
        {
            if(Input.GetAxis("Jump") != 0)
                moveDirection.y = jumpForce;
        }
       
    }
}

