using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reference
{
    public class GameManager : MonoBehaviour
    {
        
        public static GameManager Instance;

        public ScoreManager scoreManager;
        public UIManager uiManager;

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            GameState.SetState(GameStates.Menu);
        }
    }
}

