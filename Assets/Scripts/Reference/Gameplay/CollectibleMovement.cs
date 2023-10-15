using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reference
{
    public class CollectibleMovement : MonoBehaviour
    {
        [SerializeField] float moveSpeed;
        [SerializeField] Vector3 moveDirection;


        // Update is called once per frame
        void Update()
        {
            MoveCollectible();
        }

        void MoveCollectible()
        {
            if (GameState.GetState() == GameStates.Over) return;
            if (GameState.GetState() == GameStates.Menu) return;

            transform.position += moveDirection * moveSpeed * Time.deltaTime;
        }
    }

}
