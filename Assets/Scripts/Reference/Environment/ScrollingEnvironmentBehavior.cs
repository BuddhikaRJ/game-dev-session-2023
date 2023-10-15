using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reference
{
    public class ScrollingEnvironmentBehavior : MonoBehaviour
    {
        [SerializeField] Vector2 direction;
        [SerializeField] float speed;
        [SerializeField] Material envMaterial;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            moveEnvironment();
        }

        void moveEnvironment()
        {
            if (GameState.GetState() == GameStates.Over) { return; }
            
            envMaterial.mainTextureOffset += direction * speed * Time.deltaTime;
        }
    }
}

