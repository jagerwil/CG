using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonPhysicsMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 0f;

    
    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * _speed * Time.fixedDeltaTime, Space.World);
    }
}
