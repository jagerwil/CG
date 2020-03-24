using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterCube5 : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Vector3 _mouseOffset;
    private float _mouseZCoord;


    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void OnMouseDown()
    {
        Debug.Log("LMB pressed!");

        _mouseZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        _mouseOffset = gameObject.transform.position - GetMousePosition();
    }

    private Vector3 GetMousePosition()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = _mouseZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        transform.position = GetMousePosition() + _mouseOffset;
        _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, 0f, _rigidbody.velocity.z);
    }
}
