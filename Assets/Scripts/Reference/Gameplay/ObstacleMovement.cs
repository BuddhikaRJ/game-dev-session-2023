using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reference
{
    public class ObstacleMovement : MonoBehaviour
    {
        [SerializeField] Vector3 moveDirection;
        [SerializeField] float moveSpeed;


        // Update is called once per frame
        void Update()
        {
            MoveObstacle();
        }

        void MoveObstacle()
        {
            if (GameState.GetState() == GameStates.Over) return;
            if (GameState.GetState() == GameStates.Menu) return;
            transform.position += moveDirection * moveSpeed * Time.deltaTime;
        }
    }

}
