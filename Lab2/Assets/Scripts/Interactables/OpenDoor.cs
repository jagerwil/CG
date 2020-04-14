
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour, IInteractable
{
    [SerializeField] private Transform _rotatePoint;
    private bool _isDoorOpened = false;


    public void Interact()
    {
        _isDoorOpened = !_isDoorOpened;

        float angle = _isDoorOpened ? 90f : -90f;
        transform.parent.RotateAround(_rotatePoint.position, Vector3.up, angle);
    }
}
