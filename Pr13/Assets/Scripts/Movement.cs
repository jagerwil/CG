using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    [SerializeField] private float _jumpHeight = 1f;
    [SerializeField] private float _gravity = -9.8f;
    [SerializeField] private Transform _checkGround;
    [SerializeField] private float _checkGroundRadius = 0.4f;
    [SerializeField] private LayerMask _groundLayer;

    private CharacterController _charController;
    private Vector3 _velocity = Vector3.zero;
    private bool _isGrounded = false;

    private void Start()
    {
        _charController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Vector3 movement = Vector3.zero;

        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");
        movement = movement.normalized * _speed;

        _isGrounded = Physics.CheckSphere(_checkGround.position, _checkGroundRadius, _groundLayer);
        movement.y = _isGrounded ? 0f : _velocity.y + _gravity * Time.deltaTime;
        _velocity = transform.rotation * movement;

        if (Input.GetButtonDown("Jump") && _isGrounded)
        {
            _velocity.y = Mathf.Sqrt(_jumpHeight * _gravity * -2);
        }
        _charController.Move(_velocity * Time.deltaTime);
    }
}
