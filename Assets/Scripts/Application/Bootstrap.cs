using Characters;
using Cinemachine;
using Systems.Movement;
using Systems.Score;
using UnityEngine;

namespace Application
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Transform _playerSpawnPoint;
        [SerializeField] private CinemachineVirtualCamera _virtualCamera;
        
        private GameObject _playerGameObject;
        private Player _player;
        private MovementController _movementController;
        private ScoreController _scoreController;

        private void Awake()
        {
            var playerPrefab = Resources.Load<GameObject>("Prefabs/Characters/Hero_0");
            _playerGameObject = Instantiate(playerPrefab, _playerSpawnPoint.position, _playerSpawnPoint.rotation);
            
            _player = _playerGameObject.GetComponent<Player>();
            _movementController = _playerGameObject.GetComponent<MovementController>();
            
            var scoreControllerGameObject = new GameObject("ScoreController");
            _scoreController = scoreControllerGameObject.AddComponent<ScoreController>();
            
            _player.Init();
            _movementController.Init();
            _scoreController.Init();
            _virtualCamera.Follow = _player.transform;
        }
    }
}
