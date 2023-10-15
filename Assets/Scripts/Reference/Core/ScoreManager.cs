using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reference
{
    public class ScoreManager : MonoBehaviour
    {
        private int score;

        public void AddScore(int value)
        {
            score += value;
            Debug.Log(score);
        }

        public int GetScore()
        {
            return score;
        }

        public void ResetScore()
        {
            score = 0;
        }

    }
}

