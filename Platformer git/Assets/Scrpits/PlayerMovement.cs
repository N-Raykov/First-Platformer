using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D _rb;
    public float _speed;
    public float _JumpForce;

    [SerializeField] private Transform _GroundCheck;
    [SerializeField] private Vector2 _GroundCheckSize;

    public Animator animator;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Movement();
    }

    void Update()
    {
        Jump();
    }

    void Movement()
    {
        float xSpeed = Input.GetAxisRaw("Horizontal") * _speed * Time.deltaTime;

        _rb.velocity = new Vector2(xSpeed, _rb.velocity.y);

        animator.SetFloat("Speed", Mathf.Abs(xSpeed));
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && CanJump())
        {
            animator.SetBool("IsJumping", true);
            _rb.gravityScale = 2f;
            _rb.AddForce(new Vector2(0, _JumpForce));
        }
        else if (!Input.GetKey(KeyCode.Space) && _rb.velocity.y < 0)
        {
            _rb.gravityScale = 3f;
        }
        if (_rb.velocity.y == 0)
        {
            animator.SetBool("IsJumping", false);
        }
    }

    private bool CanJump()
    {
        return Physics2D.OverlapBox(_GroundCheck.position, _GroundCheckSize, 0, LayerMask.GetMask("Ground"));
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(_GroundCheck.position, _GroundCheckSize);
    }
}
