using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E pressed!");
            SceneManager.LoadScene("SteamScene");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("R pressed!");
            SceneManager.LoadScene("SnowScene");
        }
    }
}
