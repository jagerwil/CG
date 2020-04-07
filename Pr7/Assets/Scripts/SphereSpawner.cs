using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    [SerializeField] GameObject _prefab1;
    [SerializeField] GameObject _prefab2;

    [SerializeField] private Transform _spawnPoint1;
    [SerializeField] private Transform _spawnPoint2;

    private Transform _parent;


    private void Start()
    {
        _parent = GameObject.Find("[Spawned]")?.transform;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("R button pressed!");
            Instantiate(_prefab1, _spawnPoint1.position, _spawnPoint1.rotation, _parent);
            Instantiate(_prefab2, _spawnPoint2.position, _spawnPoint2.rotation, _parent);
        }
    }
}
