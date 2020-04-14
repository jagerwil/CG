using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLight : MonoBehaviour, IInteractable
{
    [SerializeField] private Light _light;
    private bool _isLightTurned = false;

    
    public void Interact()
    {
        _isLightTurned = !_isLightTurned;

        _light.enabled = _isLightTurned;

    }
}
