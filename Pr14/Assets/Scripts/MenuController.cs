using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject _spherePrefab;
    [SerializeField] private GameObject _cubePrefab;
    [SerializeField] private GameObject _menuObject;
    [SerializeField] private Transform _spawnPoint;

    private bool _isActive;
    
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            _isActive = !_isActive;
            _menuObject.SetActive(_isActive);
        }
    }

    public void SpawnSphere()
    {
        Instantiate(_spherePrefab, _spawnPoint.position, _spawnPoint.rotation);
    }

    public void SpawnCube()
    {
        Instantiate(_cubePrefab, _spawnPoint.position, _spawnPoint.rotation);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
