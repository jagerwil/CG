using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterCube1 : MonoBehaviour
{
    [SerializeField] private GameObject _targetGameObject;
    [Range(0, 1000)] [SerializeField] private int _forceIntencity = 100;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("R pressed!");
            _targetGameObject.GetComponent<Rigidbody>().AddForce(0, _forceIntencity, 0);
        }
    }
}
