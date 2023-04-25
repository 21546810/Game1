using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject tutorialMenu;
    
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void DisplayTutorial()
    {
        tutorialMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void HideTutorial()
    {
        tutorialMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
