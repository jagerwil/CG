using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereAnimController : MonoBehaviour
{
    private Animator _animator;
    

    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("[E]: Animation changed!");
            _animator.SetTrigger("SwitchAnimTrigger");
        }
    }
}
