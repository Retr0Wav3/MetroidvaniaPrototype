using UnityEngine;

namespace Systems.Score
{
    public class ScoreController : MonoBehaviour
    {
        public static ScoreController Instance { get; private set; }
        
        public int CurrentScore { get; private set; }
        public const int MaxScore = 250;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
            }
            else
            {
                Instance = this;
                DontDestroyOnLoad(this);
            }
        }

        public void Init()
        {
            CurrentScore = 0;
        }

        public void IncreaseScore(int value)
        {
            CurrentScore = Mathf.Clamp(CurrentScore + value, 0, MaxScore);
        }
    }
}