using UnityEngine;
using UnityEngine.InputSystem;

namespace Labs
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField]
        private float _movementSpeed = 5f;
		[SerializeField]
		private float _jumpSpeed = 5f;
		[SerializeField]
        private float _groundCheckRadius = 0.3f;
        [SerializeField]
        private LayerMask _groundMask;

        private Vector2 _groundCheckPos;
        private float _colliderRadius;
		private float _xMovement;
        private Rigidbody2D _rb;
        private SpriteRenderer _spriteRenderer;
        private Animator _animator;
        private State _state;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
			_colliderRadius = GetComponent<CircleCollider2D>().radius;
			_spriteRenderer = GetComponent<SpriteRenderer>();
			_animator = GetComponent<Animator>();
		}

		private void FixedUpdate()
        {
			_rb.velocity = new(_xMovement * _movementSpeed, _rb.velocity.y);

            CheckState();
		}

        private void CheckState()
        {
            if (!IsGrounded())
            {
                SetState(State.Jump);
                return;
			}

            if (_xMovement != 0)
            {
                SetState(State.Run);
                return;
            }

            SetState(State.Idle);
        }

        private void SetState(State state)
        {
            _state = state;
            var stateName = _state.ToString();
            _animator.Play(stateName);
            Debug.Log(stateName);
        }

        private bool IsGrounded()
        {
            _groundCheckPos = new(gameObject.transform.position.x,
                gameObject.transform.position.y - _colliderRadius);

            return Physics2D.OverlapCircle(_groundCheckPos,
				_groundCheckRadius, _groundMask);
		}

		public void Move(InputAction.CallbackContext context)
        {
		    _xMovement = context.ReadValue<Vector2>().x;
            CheckFacingDirection();
		}

        private void CheckFacingDirection()
        {
            if (_xMovement == 0)
            {
                return;
            }
			FlipCharacter();
		}

        private void FlipCharacter()
        {
            _spriteRenderer.flipX = _xMovement < 0;
		}

		public void Jump(InputAction.CallbackContext context)
        {
            if (context.performed && IsGrounded())
            {
                _rb.velocity = new(_rb.velocity.x, _jumpSpeed);
            }
        }
    }
}
