using UnityEngine;

namespace Scripts.Input
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float _speed;
        private Vector3 _directionVector;
        
        public void SetMovementDirection(Vector3 direction)
        {
            _directionVector = direction;
        }

        private void Update()
        {
            if (_directionVector != Vector3.zero)
                transform.position += _directionVector * (_speed * Time.deltaTime);
        }
    }
}