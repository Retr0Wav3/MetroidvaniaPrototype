using Characters;
using Systems.Score;
using UnityEngine;

namespace Collectables
{
    [RequireComponent(typeof(Collider2D))]
    public class Coin : MonoBehaviour
    {
        [SerializeField] private int _value;
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent(out Player player))
            {
                ScoreController.Instance.IncreaseScore(_value);
                Debug.Log($"Current score: {ScoreController.Instance.CurrentScore}");
                Destroy(gameObject);
            }
        }
    }
}