using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class StartMenu : MonoBehaviour
{
    private Button PlayButton;
    private Button QuitButton;

    private void Start()
    {
        PlayButton = GameObject.Find("Play Button").GetComponent("Button") as Button;
        QuitButton = GameObject.Find("Quit Button").GetComponent("Button") as Button;
        PlayButton.onClick.AddListener(delegate { SceneManager.LoadScene("Entreance"); });
        QuitButton.onClick.AddListener(delegate { Application.Quit(); });
    }
}
