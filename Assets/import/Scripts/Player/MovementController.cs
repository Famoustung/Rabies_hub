using UnityEngine;
using UnityEngine.InputSystem;

namespace TheProphecy.Player
{
    public class MovementController : MonoBehaviour
    {
        
        [Header("References")]
        [SerializeField] private Joystick _moveJoystick;
        private TrailRenderer _trailRenderer;
        private SpriteRenderer _spriteRenderer;
        private Rigidbody2D _rigidbody;

        [Header("Basic Movement")]
        public float speed;
        private Vector2 _direction = new Vector2(1, 0);
        private Vector3 _movement;

        private Vector2 movement;
        
        private Rigidbody2D rb;

        private float moveY;
        private float moveX;
        public Animator animator;
        private void Start()
        {

            
             
            rb = GetComponent<Rigidbody2D>();
            _trailRenderer = GetComponent<TrailRenderer>();
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
           
        }

        private void FixedUpdate()
        {
                
            
                Move();
                RotateCharacterWhenMove();
           
                
           
        }

        private void Move()
        {
            
            
            _movement.x = _moveJoystick.Horizontal;
            _movement.y = _moveJoystick.Vertical;

            
            animator.SetFloat("Horizontal",_movement.x);
            animator.SetFloat("Vertical",_movement.y);
            animator.SetFloat("Speed",movement.sqrMagnitude+0.1f);
            
            //transform.Translate(_movement * speed * Time.deltaTime);
            _rigidbody.MovePosition(transform.position + _movement * speed * Time.deltaTime);
        }

        private void RotateCharacterWhenMove()
        {
            if (_movement.x != 0 || _movement.y != 0)
            {
                _direction = _moveJoystick.Direction;

                if (_movement.x < 0)
                {
                    _spriteRenderer.flipX = true;
                }

                else if(_movement.x > 0)
                {
                    _spriteRenderer.flipX = false;
                }
            }
            
        }

       
    }
}
