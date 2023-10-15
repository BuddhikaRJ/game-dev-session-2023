using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reference
{
    public class ObstacleCollision : MonoBehaviour, IHitPlayer
    {
        public void OnHitPlayer()
        {
            GameManager.Instance.uiManager.OnGameOver();
            GameState.SetState(GameStates.Over);
        }
    }

}
