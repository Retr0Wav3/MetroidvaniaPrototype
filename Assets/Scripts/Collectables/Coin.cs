using Systems.Movement;
using UnityEngine;

namespace Collectables
{
    public class Coin : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent(out MovementController controller))
            {
                Destroy(gameObject);
            }
        }
    }
}