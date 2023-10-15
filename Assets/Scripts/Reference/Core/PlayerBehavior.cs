using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reference
{
    public class PlayerBehavior : MonoBehaviour
    {
        [Header("Inputs")]
        //inputs
        [SerializeField] int jumpMouseBtn;

        [Header("Movement")]
        //movement
        [SerializeField] float gravity = 9.8f;
        Vector3 movement;
        [SerializeField] float jumpForce;
        [SerializeField] Vector3 forceDirection;
        float acceleration;
        [SerializeField] float maxAcceleration;
        [SerializeField] float maxVelocity;

        [Header("Animation")]
        //animation
        [SerializeField] Animator animator;

        [Header("Limits")]
        [SerializeField] float maxY;
        [SerializeField] float minY;


        // Update is called once per frame
        void Update()
        {
            MovePlane();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.TryGetComponent<IHitPlayer>(out IHitPlayer hit))
            {
                hit.OnHitPlayer();
            }
        }

        void MovePlane()
        {
            if (GameState.GetState() == GameStates.Over) return;
            if (GameState.GetState() == GameStates.Menu) return;

            //input and movement
            if (Input.GetMouseButton(jumpMouseBtn))
            {
                acceleration = maxAcceleration;
            }
            else
            {
                acceleration = 0f;
            }

            movement.y += (gravity + acceleration) * Time.deltaTime;
            movement.y = movement.y > maxVelocity ? maxVelocity : movement.y;
            transform.position += movement * Time.deltaTime;


            animator.speed = movement.y * 0.5f;

        }
    }
}

