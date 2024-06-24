using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Scripts.Input
{
    public class MovementController : MonoBehaviour
    {
        private Player _player;

        private void Awake()
        {
            TryGetComponent(out _player);
        }

        public void OnMove(InputAction.CallbackContext context)
        { 
            var direction = context.ReadValue<Vector2>();
            _player.SetMovementDirection(direction);
        }
    }
}