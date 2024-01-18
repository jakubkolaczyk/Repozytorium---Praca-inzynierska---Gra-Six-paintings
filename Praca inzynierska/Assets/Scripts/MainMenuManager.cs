using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject Buttons;
    public GameObject Controls;
    public GameObject Credits;
    public GameObject Paintings;
    public void StartGame()
    {
        ManagerScen.questStatus = -1;
        SceneManager.LoadScene(2);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void ShowControls()
    {
        Buttons.SetActive(false);
        Paintings.SetActive(false);
        Controls.SetActive(true);
    }

    public void ShowCredits()
    {
        Buttons.SetActive(false);
        Paintings.SetActive(false);
        Credits.SetActive(true);
    }

    public void HideControls()
    {
        Buttons.SetActive(true);
        Paintings.SetActive(true);
        Controls.SetActive(false);
    }

    public void HideCredits()
    {
        Buttons.SetActive(true);
        Paintings.SetActive(true);
        Credits.SetActive(false);
    }
}
