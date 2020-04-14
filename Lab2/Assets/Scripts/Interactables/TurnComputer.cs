using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnComputer : MonoBehaviour, IInteractable
{
    [SerializeField] private Material _activeMaterial;
    [SerializeField] private Material _deactiveMaterial;

    private bool _isComputerTurned = false;
    private MeshRenderer _renderer;


    private void Start()
    {
        _renderer = transform.Find("Monitor").GetComponent<MeshRenderer>();
    }

    public void Interact()
    {
        _isComputerTurned = !_isComputerTurned;

        Material currentMaterial = _isComputerTurned ? _activeMaterial : _deactiveMaterial;
        _renderer.material = currentMaterial;
    }
}
