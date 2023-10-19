using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 direction;

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * direction * Time.deltaTime;
    }
}
