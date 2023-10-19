using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] Vector3 movement;
    [SerializeField] float gravity = 9.8f;
    float acceleration;
    [SerializeField] float maxAcceleration;
    [SerializeField] float maxVelocity;

    [Header("Animations")]
    [SerializeField] Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
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

        animator.speed = movement.y < 0 ? 0 : movement.y * 0.5f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("ground"))
        {
            Debug.LogError("Game Over");
        }

        else
        {
            Debug.Log("Add Score");
        }
        
    }
}
