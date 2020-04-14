using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{
    Transform _cameraTransform;

    private void Start()
    {
        _cameraTransform = Camera.main.transform;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("---------------");
            Debug.Log("E pressed");
            Ray ray = new Ray(_cameraTransform.position, _cameraTransform.forward);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo, 4f))
            {
                IInteractable target = hitInfo.transform.GetComponent<IInteractable>();

                if (target != null)
                {
                    Debug.Log("Interacted!");
                    target.Interact();
                }
            }
        }
    }
}
