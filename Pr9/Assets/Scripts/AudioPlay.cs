using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    private AudioSource _audio;


    void Start()
    {
        _audio = transform.Find("Audio Source").GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        _audio.Play();
    }
}
