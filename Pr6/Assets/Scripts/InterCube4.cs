using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterCube4 : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("LMB pressed!");
        Debug.Log(name);
        Debug.Log(transform.position);
        Debug.Log(GetComponent<Renderer>().material.color);
        Debug.Log(GetComponent<Rigidbody>().mass);
    }
}
