using Characters;
using UnityEngine;
using UnityEngine.InputSystem;
using Utils;

namespace Systems.Movement
{
    [RequireComponent(typeof(Player))]
    public class MovementController : MonoBehaviour
    {
        [SerializeField] LayerChecker _groundCheker;
        
        private Player _player;
        private Rigidbody2D _rigidbody;
        private Vector2 _moveDirection;
        private bool _isJumping;
        private Vector3 _debugSphereOffset;

        public void Init()
        {
            _player = GetComponent<Player>();
            _rigidbody = GetComponent<Rigidbody2D>();
            _debugSphereOffset = _groundCheker.ColliderOffset;
        }

        public void FixedUpdate()
        {
            _player.Move(_moveDirection);
            
            if (_isJumping)
            {
                if (IsGrounded())
                    _player.Jump();
            }
            else if (_rigidbody.velocity.y > 0f)
            {
                _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _rigidbody.velocity.y * 0.5f);
            }
        }

        public void OnMove(InputAction.CallbackContext context)
        { 
            _moveDirection = context.ReadValue<Vector2>();
        }

        public void OnJump(InputAction.CallbackContext context)
        {
            var jumpInput = context.ReadValue<Vector2>();
            _isJumping = jumpInput.y > 0f;
        }

        private bool IsGrounded()
        {
            return _groundCheker.IsTouchingLayer;
        }

        #region GroundCollisionDebug
        // private void OnDrawGizmos()
        // {
        //     Gizmos.color = IsGrounded() ? Color.green : Color.red;
        //     Gizmos.DrawSphere(transform.position + _debugSphereOffset, 0.25f);
        // }
        #endregion
    }
}