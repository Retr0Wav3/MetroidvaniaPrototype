using Characters;
using Systems.Movement;
using UnityEngine;
using Utils;

namespace Application
{
    public class Bootstrap : MonoBehaviour
    {
        public GameObject playerPrefab;
        public Transform playerSpawnPoint;
    
        private Player _player;
        private MovementController _movementController;

        private void Awake()
        {
            _player = new Player(4f, 13f);
            ServiceLocator.RegisterAs(_player, typeof(Player));
        
            var heroGameObject = Instantiate(playerPrefab, playerSpawnPoint.position, playerSpawnPoint.rotation);
            _movementController = heroGameObject.GetComponent<MovementController>();
            _movementController.Init();
        
            //DontDestroyOnLoad(this);
        }
    }
}
