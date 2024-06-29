using UnityEngine;

namespace Utils
{
    [RequireComponent(typeof(Collider2D))]
    public class LayerChecker : MonoBehaviour
    {
        [SerializeField] private LayerMask _trackedLayer;
        public Vector2 ColliderOffset => _collider.offset;
        public bool IsTouchingLayer { get; private set; }
        
        private Collider2D _collider;

        private void Awake()
        {
            _collider = GetComponent<Collider2D>();
        }

        private void OnTriggerStay2D(Collider2D other)
        {
            IsTouchingLayer = _collider.IsTouchingLayers(_trackedLayer);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            IsTouchingLayer = _collider.IsTouchingLayers(_trackedLayer);
        }
    }
}