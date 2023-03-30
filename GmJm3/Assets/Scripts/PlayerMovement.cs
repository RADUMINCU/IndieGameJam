using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] float _speed, _jump;
    [SerializeField] Transform SpriteTransform;
    Vector2 _movement;
    

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {

    }

    private void Update()
    {
        _rb.velocity = new Vector2(_movement.x * _speed, _rb.velocity.y);

        if(_movement.x > 0)
        {
            SpriteTransform.localScale = new Vector3(1, 1, 1);
        }
        else if(_movement.x < 0)
        {
            SpriteTransform.localScale = new Vector3(-1, 1, 1);
        }
    }

    public void Walk(InputAction.CallbackContext ctx)
    {
        _movement = ctx.ReadValue<Vector2>();
        //_rb.velocity = ctx.ReadValue<Vector2>() * _speed;
        

    }

    public void Jump(InputAction.CallbackContext ctx)
    {
        //_rb.velocity = ctx.ReadValue<Vector2>() * _speed;
        _rb.AddForce(ctx.ReadValue<Vector2>() * _jump);
    }
}

