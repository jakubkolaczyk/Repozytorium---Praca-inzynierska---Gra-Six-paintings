using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LetterManager : MonoBehaviour
{
    public GameObject letterObject;
    public TextMeshProUGUI openLetterText;
    private GameObject player;
    public GameObject newspaper;
    public GameObject letterText1;
    public GameObject letterText2;
    public GameObject letterText3;
    private bool isDisplayingText;
    float diff;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        isDisplayingText = false;
    }

    void Update()
    {
        diff = Vector3.Distance(player.transform.position, transform.position);
        if (diff < 2f)
        {
            openLetterText.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Return))
            {
                ShowLetter();
            }
        }
        else
        {
            openLetterText.gameObject.SetActive(false);
        }
        if (isDisplayingText)
        {
            openLetterText.gameObject.SetActive(false);
        }
        if (ManagerScen.questStatus == 0 || ManagerScen.questStatus == 4 || ManagerScen.questStatus == 12)
        {
            letterObject.SetActive(true);
        }
        else if (ManagerScen.questStatus == -1)
        {
            newspaper.SetActive(true);
            Time.timeScale = 0f;
            PauseMenuManager.isPaused = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            letterObject.SetActive(false);
        }

    }

    private void ShowLetter()
    {
        if (ManagerScen.questStatus==0)
        {
            letterText1.gameObject.SetActive(true);
            PauseMenuManager.isPaused = true;
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            isDisplayingText = true;
        }
        else if (ManagerScen.questStatus==4)
        {
            letterText2.gameObject.SetActive(true);
            PauseMenuManager.isPaused = true;
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            isDisplayingText = true;
        }
        else if (ManagerScen.questStatus == 12)
        {
            letterText3.gameObject.SetActive(true);
            PauseMenuManager.isPaused = true;
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            isDisplayingText = true;
        }

    }
    public void AcceptLetter1()
    {
        letterText1.SetActive(false);
        ManagerScen.questStatus = 1;
        PauseMenuManager.isPaused = false;
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        openLetterText.gameObject.SetActive(false);
    }
    public void AcceptLetter2()
    {
        letterText2.SetActive(false);
        ManagerScen.questStatus = 5;
        PauseMenuManager.isPaused = false;
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        openLetterText.gameObject.SetActive(false);
    }
    public void AcceptLetter3()
    {
        letterText3.SetActive(false);
        ManagerScen.questStatus = 13;
        PauseMenuManager.isPaused = false;
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        openLetterText.gameObject.SetActive(false);
    }
    public void AcceptNewspaper()
    {
        newspaper.SetActive(false);
        ManagerScen.questStatus = 0;
        PauseMenuManager.isPaused = false;
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        openLetterText.gameObject.SetActive(false);
    }
}
