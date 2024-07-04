using Systems.Movement;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider2D))]
public class SceneReloader : MonoBehaviour
{
    private string _sceneName;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out MovementController controller))
        {
            _sceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(_sceneName);
        }
    }
}