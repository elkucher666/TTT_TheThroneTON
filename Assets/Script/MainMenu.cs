using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using System;

public class MainMenu : MonoBehaviour
{
    public Button startButton;
    public Button exitButton;

    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        startButton = root.Q<Button>("StartButton");
        exitButton = root.Q<Button>("ExitButton");

        startButton.clicked += StartButtonPressed;
        exitButton.clicked += ExitButtonPressed;
    }

    private void ExitButtonPressed()
    {
        Application.Quit();
    }

    private void StartButtonPressed()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
