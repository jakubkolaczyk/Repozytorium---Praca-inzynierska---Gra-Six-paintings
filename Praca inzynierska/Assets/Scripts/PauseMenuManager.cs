using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenuUI;
    public GameObject letter1;
    public GameObject letter2;
    public GameObject letter3;

    private void Start()
    {
        if (ManagerScen.questStatus==0 && SceneManager.GetActiveScene().buildIndex==2)
        {
            letter1.SetActive(true);
            isPaused = true;
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
        }
        else if (ManagerScen.questStatus==4 && SceneManager.GetActiveScene().buildIndex == 2)
        {
            letter2.SetActive(true);
            isPaused = true;
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
        }
        else if (ManagerScen.questStatus == 12 && SceneManager.GetActiveScene().buildIndex == 2)
        {
            letter3.SetActive(true);
            isPaused = true;
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        isPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void AcceptLetter1()
    {
        letter1.SetActive(false);
        ManagerScen.questStatus = 1;
        isPaused = false;
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void AcceptLetter2()
    {
        letter2.SetActive(false);
        ManagerScen.questStatus = 5;
        isPaused = false;
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void AcceptLetter3()
    {
        letter3.SetActive(false);
        ManagerScen.questStatus = 13;
        isPaused = false;
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
