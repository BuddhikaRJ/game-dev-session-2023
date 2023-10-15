using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reference
{
    public class Collectible : MonoBehaviour, IHitPlayer
    {
        
        

        public void OnHitPlayer()
        {
            Debug.Log("Player Hit Colectible");
            gameObject.SetActive(false);
            GameManager.Instance.scoreManager.AddScore(1);
            int score = GameManager.Instance.scoreManager.GetScore();
            GameManager.Instance.uiManager.SetScoreText(score);
        }
    }

}
