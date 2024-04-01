using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleUI : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject tutorialPanel;

    public GameObject playButton;
    public GameObject tutorialButton;

    public GameObject quitButton;

    public void ShowTutorialPanel()
    {
        mainMenuPanel.SetActive(false);
        tutorialPanel.SetActive(true);
    }

        public void ShowmainMenuPanel()
    {
        mainMenuPanel.SetActive(true);
        tutorialPanel.SetActive(false);
    }

    public void StatGame()
    {
        mainMenuPanel.SetActive(false);
        tutorialPanel.SetActive(false);
        playButton.SetActive(false);
        tutorialButton.SetActive(false);
        quitButton.SetActive(false);
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(0);
    }

    public void Quitgame()
    {
        Application.Quit();
        Debug.Log("Quit game.");
    }
}
