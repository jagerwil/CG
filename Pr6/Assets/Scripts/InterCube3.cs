using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterCube3 : MonoBehaviour
{
    [SerializeField] private Color _interactionColor = Color.blue;
    private Color _startColor;
    private Renderer _rendererProp;


    void Start()
    {
        _rendererProp = GetComponent<Renderer>();
    }

    private void OnMouseEnter()
    {
        _startColor = _rendererProp.material.color;
        _rendererProp.material.color = _interactionColor;
    }

    private void OnMouseExit()
    {
        _rendererProp.material.color = _startColor;
    }
}
