using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] float _speed, _jump;
    Vector2 _movement;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {

    }

    public void Walk(InputAction.CallbackContext ctx)
    {
        _movement = ctx.ReadValue<Vector2>();
        //_rb.velocity = ctx.ReadValue<Vector2>() * _speed;
        _rb.velocity = new Vector2(_movement.x * _speed, 0);

    }

    public void Jump(InputAction.CallbackContext ctx)
    {
        //_rb.velocity = ctx.ReadValue<Vector2>() * _speed;
        _rb.AddForce(ctx.ReadValue<Vector2>() * _jump);
    }
}

