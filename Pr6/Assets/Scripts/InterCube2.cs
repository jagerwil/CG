using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterCube2 : MonoBehaviour
{
    [SerializeField] private Color _interactionColor = Color.red;
    private Renderer _renderer;


    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("T pressed!");
            _renderer.material.color = _interactionColor;
        }
    }
}
