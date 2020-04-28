using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private Image image;
    [SerializeField] private Sprite changeSprite;


    public void Close()
    {
        panel.SetActive(false);
    }

    public void ChangeImage()
    {
        image.sprite = changeSprite;
    }
}
