using Systems.Movement;
using UnityEngine;

namespace Characters
{
    public class Player : IMovable
    {
        public float Speed { get; }
        public float JumpSpeed { get; }
        
        public Player(float speed, float jumpSpeed)
        {
            Speed = speed;
            JumpSpeed = jumpSpeed;
        }

        public void Move(Rigidbody2D rigidbody, Vector2 direction)
        {
            rigidbody.velocity = new Vector2(direction.x * Speed, rigidbody.velocity.y);
        }

        public void Jump(Rigidbody2D rigidbody)
        {
            rigidbody.AddForce(Vector2.up * JumpSpeed, ForceMode2D.Impulse);
        }
    }
}