using UnityEngine;

namespace Scripts.Input
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float _speed;
        private Vector3 _directionVector;
        
        public void SetMovementDirection(float direction)
        {
            _directionVector.x = direction;
        }

        private void Update()
        {
            if (_directionVector.x != 0)
                transform.position += _directionVector * (_speed * Time.deltaTime);
        }
    }
}