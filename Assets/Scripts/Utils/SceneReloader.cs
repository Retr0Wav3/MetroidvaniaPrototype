using Characters;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Utils
{
    [RequireComponent(typeof(Collider2D))]
    public class SceneReloader : MonoBehaviour
    {
        private string _sceneName;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent(out Player player))
            {
                _sceneName = SceneManager.GetActiveScene().name;
                SceneManager.LoadScene(_sceneName);
            }
        }
    }
}