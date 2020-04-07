using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 0f;
    private Rigidbody _rigidbody;


    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(0f, _rigidbody.velocity.y, _speed);
    }
}
