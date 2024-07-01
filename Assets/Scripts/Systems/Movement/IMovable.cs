using UnityEngine;

namespace Systems.Movement
{
    public interface IMovable
    {
        float Speed { get; }

        void Move(Rigidbody2D rigidbody, Vector2 direction);
        void Jump(Rigidbody2D rigidbody);
    }
}