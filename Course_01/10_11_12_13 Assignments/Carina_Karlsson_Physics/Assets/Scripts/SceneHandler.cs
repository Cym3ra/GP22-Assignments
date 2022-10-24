using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneHandler : MonoBehaviour
{

    public GameObject creditsPanel;


    public void OnButtonPressed()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ShowCreditsPanel()
    {
        creditsPanel.SetActive(!creditsPanel.activeSelf);
    }
}
