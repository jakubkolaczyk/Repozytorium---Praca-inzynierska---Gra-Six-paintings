using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialogueBox;
    public TextMeshProUGUI enterDialogText;
    private GameObject player;
    private GameObject fabCharacter;
    public TextMeshProUGUI dialogueText;
    public string[] dialoguePoliceman1;
    public string[] dialogueShopkeeper;
    public string[] dialogueDoctor;
    public string[] dialoguePoliceman2;
    public string[] dialogueGarden;
    public string[] dialogueGarden2;
    public string[] dialogueWorkshop;
    public string[] dialoguePoliceman3;
    public string[] dialogueTown;
    public string[] dialogueTown2;
    public string[] dialoguePoliceman4;
    private int currentDialogueIndex = 0;
    private bool isDisplayingText = false;
    float diff;
    int sceneIndex;
    void Start()
    {
        dialogueBox.SetActive(false);
        Debug.Log(ManagerScen.questStatus);
        player = GameObject.FindGameObjectWithTag("Player");
        if (ManagerScen.questStatus==1 || ManagerScen.questStatus==5 || ManagerScen.questStatus==7 || ManagerScen.questStatus==9 || ManagerScen.questStatus==10 || ManagerScen.questStatus==13) 
        {
            fabCharacter = GameObject.FindGameObjectWithTag("Policeman");
        }
        else
        {
            fabCharacter = GameObject.FindGameObjectWithTag("FabCharacter");
        }        
    }

    void Update()
    {
        if (ManagerScen.questStatus == 1 || ManagerScen.questStatus == 5 || ManagerScen.questStatus == 7 || ManagerScen.questStatus == 9 || ManagerScen.questStatus == 10 || ManagerScen.questStatus == 13)
        {
            fabCharacter = GameObject.FindGameObjectWithTag("Policeman");
        }
        else
        {
            fabCharacter = GameObject.FindGameObjectWithTag("FabCharacter");
        }
        diff = Vector3.Distance(player.transform.position, fabCharacter.transform.position);        
        if(diff < 2f)
        {
            enterDialogText.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (isDisplayingText)
                {
                    ShowNextSentence();
                }
                else
                {
                    ShowNextDialogue();
                }
            }
        }
        else
        {
            enterDialogText.gameObject.SetActive(false);
        }
        if (isDisplayingText)
        {
            enterDialogText.gameObject.SetActive(false);
        }
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }


    void ShowNextDialogue()
    {
        if (ManagerScen.questStatus==1 && sceneIndex == 8)
        {
            if (currentDialogueIndex < dialoguePoliceman1.Length)
            {
                dialogueBox.SetActive(true);
                dialogueText.text = "";
                isDisplayingText = true;
                PauseMenuManager.isPaused = true;
                Time.timeScale = 0f;
                ShowNextSentence();
            }
            else
            {
                PauseMenuManager.isPaused = false;
                Time.timeScale = 1f;
                dialogueBox.SetActive(false);
            }
        }
        if (ManagerScen.questStatus == 2 && sceneIndex == 5)
        {
            if (currentDialogueIndex < dialogueShopkeeper.Length)
            {
                dialogueBox.SetActive(true);
                dialogueText.text = "";
                isDisplayingText = true;
                PauseMenuManager.isPaused = true;
                Time.timeScale = 0f;
                ShowNextSentence();
            }
            else
            {
                PauseMenuManager.isPaused = false;
                Time.timeScale = 1f;
                dialogueBox.SetActive(false);
            }
        }
        if (ManagerScen.questStatus == 3 && sceneIndex == 4)
        {
            if (currentDialogueIndex < dialogueDoctor.Length)
            {
                dialogueBox.SetActive(true);
                dialogueText.text = "";
                isDisplayingText = true;
                PauseMenuManager.isPaused = true;
                Time.timeScale = 0f;
                ShowNextSentence();
            }
            else
            {
                PauseMenuManager.isPaused = false;
                Time.timeScale = 1f;
                dialogueBox.SetActive(false);
            }
        }
        if (ManagerScen.questStatus == 5 && sceneIndex == 8)
        {
            if (currentDialogueIndex < dialoguePoliceman2.Length)
            {
                dialogueBox.SetActive(true);
                dialogueText.text = "";
                isDisplayingText = true;
                PauseMenuManager.isPaused = true;
                Time.timeScale = 0f;
                ShowNextSentence();
            }
            else
            {
                PauseMenuManager.isPaused = false;
                Time.timeScale = 1f;
                dialogueBox.SetActive(false);
            }
        }
        if (ManagerScen.questStatus == 6 && sceneIndex == 7)
        {
            if (currentDialogueIndex < dialogueGarden.Length)
            {
                dialogueBox.SetActive(true);
                dialogueText.text = "";
                isDisplayingText = true;
                PauseMenuManager.isPaused = true;
                Time.timeScale = 0f;
                ShowNextSentence();
            }
            else
            {
                PauseMenuManager.isPaused = false;
                Time.timeScale = 1f;
                dialogueBox.SetActive(false);
            }
        }
        if (ManagerScen.questStatus == 7 && sceneIndex == 7)
        {
            if (currentDialogueIndex < dialogueGarden2.Length)
            {
                dialogueBox.SetActive(true);
                dialogueText.text = "";
                isDisplayingText = true;
                PauseMenuManager.isPaused = true;
                Time.timeScale = 0f;
                ShowNextSentence();
            }
            else
            {
                PauseMenuManager.isPaused = false;
                Time.timeScale = 1f;
                dialogueBox.SetActive(false);
            }
        }
        if (ManagerScen.questStatus == 8 && sceneIndex == 6)
        {
            if (currentDialogueIndex < dialogueWorkshop.Length)
            {
                dialogueBox.SetActive(true);
                dialogueText.text = "";
                isDisplayingText = true;
                PauseMenuManager.isPaused = true;
                Time.timeScale = 0f;
                ShowNextSentence();
            }
            else
            {
                PauseMenuManager.isPaused = false;
                Time.timeScale = 1f;
                dialogueBox.SetActive(false);
            }
        }
        if (ManagerScen.questStatus == 9 && sceneIndex == 8)
        {
            if (currentDialogueIndex < dialoguePoliceman3.Length)
            {
                dialogueBox.SetActive(true);
                dialogueText.text = "";
                isDisplayingText = true;
                PauseMenuManager.isPaused = true;
                Time.timeScale = 0f;
                ShowNextSentence();
            }
            else
            {
                PauseMenuManager.isPaused = false;
                Time.timeScale = 1f;
                dialogueBox.SetActive(false);
            }
        }
        if (ManagerScen.questStatus == 10 && sceneIndex == 1)
        {
            if (currentDialogueIndex < dialogueTown.Length)
            {
                dialogueBox.SetActive(true);
                dialogueText.text = "";
                isDisplayingText = true;
                PauseMenuManager.isPaused = true;
                Time.timeScale = 0f;
                ShowNextSentence();
            }
            else
            {
                PauseMenuManager.isPaused = false;
                Time.timeScale = 1f;
                dialogueBox.SetActive(false);
            }
        }
        if (ManagerScen.questStatus == 11 && sceneIndex == 1)
        {
            if (currentDialogueIndex < dialogueTown2.Length)
            {
                dialogueBox.SetActive(true);
                dialogueText.text = "";
                isDisplayingText = true;
                PauseMenuManager.isPaused = true;
                Time.timeScale = 0f;
                ShowNextSentence();
            }
            else
            {
                PauseMenuManager.isPaused = false;
                Time.timeScale = 1f;
                dialogueBox.SetActive(false);
            }
        }
        if (ManagerScen.questStatus == 13 && sceneIndex == 8)
        {
            if (currentDialogueIndex < dialoguePoliceman4.Length)
            {
                dialogueBox.SetActive(true);
                dialogueText.text = "";
                isDisplayingText = true;
                PauseMenuManager.isPaused = true;
                Time.timeScale = 0f;
                ShowNextSentence();
            }
            else
            {
                PauseMenuManager.isPaused = false;
                Time.timeScale = 1f;
                dialogueBox.SetActive(false);
            }
        }
    }

    void ShowNextSentence()
    {
        if (ManagerScen.questStatus == 1 && sceneIndex == 8)
        {
            if (currentDialogueIndex < dialoguePoliceman1.Length)
            {
                dialogueText.text = dialoguePoliceman1[currentDialogueIndex];
                currentDialogueIndex++;
            }
            else
            {
                isDisplayingText = false;
                PauseMenuManager.isPaused = false;
                Time.timeScale = 1f;
                currentDialogueIndex = 0;
                ManagerScen.questStatus = 2;
                dialogueBox.SetActive(false);
            }
        }
        if (ManagerScen.questStatus == 2 && sceneIndex == 5)
        {
            if (currentDialogueIndex < dialogueShopkeeper.Length)
            {
                dialogueText.text = dialogueShopkeeper[currentDialogueIndex];
                currentDialogueIndex++;
            }
            else
            {
                isDisplayingText = false;
                PauseMenuManager.isPaused = false;
                Time.timeScale = 1f;
                currentDialogueIndex = 0;
                ManagerScen.questStatus = 3;
                dialogueBox.SetActive(false);
            }
        }
        if (ManagerScen.questStatus == 3 && sceneIndex == 4)
        {
            if (currentDialogueIndex < dialogueDoctor.Length)
            {
                dialogueText.text = dialogueDoctor[currentDialogueIndex];
                currentDialogueIndex++;
            }
            else
            {
                isDisplayingText = false;
                PauseMenuManager.isPaused = false;
                Time.timeScale = 1f;
                currentDialogueIndex = 0;
                ManagerScen.questStatus = 4;
                dialogueBox.SetActive(false);
            }
        }
        if (ManagerScen.questStatus == 5 && sceneIndex == 8)
        {
            if (currentDialogueIndex < dialoguePoliceman2.Length)
            {
                dialogueText.text = dialoguePoliceman2[currentDialogueIndex];
                currentDialogueIndex++;
            }
            else
            {
                isDisplayingText = false;
                PauseMenuManager.isPaused = false;
                Time.timeScale = 1f;
                currentDialogueIndex = 0;
                ManagerScen.questStatus = 6;
                dialogueBox.SetActive(false);
            }
        }
        if (ManagerScen.questStatus == 6 && sceneIndex == 7)
        {
            if (currentDialogueIndex < dialogueGarden.Length)
            {
                dialogueText.text = dialogueGarden[currentDialogueIndex];
                currentDialogueIndex++;
            }
            else
            {
                isDisplayingText = false;
                PauseMenuManager.isPaused = false;
                Time.timeScale = 1f;
                currentDialogueIndex = 0;
                ManagerScen.questStatus = 7;
                dialogueBox.SetActive(false);
            }
        }
        if (ManagerScen.questStatus == 7 && sceneIndex == 7)
        {
            if (currentDialogueIndex < dialogueGarden2.Length)
            {
                dialogueText.text = dialogueGarden2[currentDialogueIndex];
                currentDialogueIndex++;
            }
            else
            {
                isDisplayingText = false;
                PauseMenuManager.isPaused = false;
                Time.timeScale = 1f;
                currentDialogueIndex = 0;
                ManagerScen.questStatus = 8;
                dialogueBox.SetActive(false);
            }
        }
        if (ManagerScen.questStatus == 8 && sceneIndex == 6)
        {
            if (currentDialogueIndex < dialogueWorkshop.Length)
            {
                dialogueText.text = dialogueWorkshop[currentDialogueIndex];
                currentDialogueIndex++;
            }
            else
            {
                isDisplayingText = false;
                PauseMenuManager.isPaused = false;
                Time.timeScale = 1f;
                currentDialogueIndex = 0;
                ManagerScen.questStatus = 9;
                dialogueBox.SetActive(false);
            }
        }
        if (ManagerScen.questStatus == 9 && sceneIndex == 8)
        {
            if (currentDialogueIndex < dialoguePoliceman3.Length)
            {
                dialogueText.text = dialoguePoliceman3[currentDialogueIndex];
                currentDialogueIndex++;
            }
            else
            {
                isDisplayingText = false;
                PauseMenuManager.isPaused = false;
                Time.timeScale = 1f;
                currentDialogueIndex = 0;
                ManagerScen.questStatus = 10;
                dialogueBox.SetActive(false);
            }
        }
        if (ManagerScen.questStatus == 10 && sceneIndex == 1)
        {
            if (currentDialogueIndex < dialogueTown.Length)
            {
                dialogueText.text = dialogueTown[currentDialogueIndex];
                currentDialogueIndex++;
            }
            else
            {
                isDisplayingText = false;
                PauseMenuManager.isPaused = false;
                Time.timeScale = 1f;
                currentDialogueIndex = 0;
                ManagerScen.questStatus = 11;
                dialogueBox.SetActive(false);
            }
        }
        if (ManagerScen.questStatus == 11 && sceneIndex == 1)
        {
            if (currentDialogueIndex < dialogueTown2.Length)
            {
                dialogueText.text = dialogueTown2[currentDialogueIndex];
                currentDialogueIndex++;
            }
            else
            {
                isDisplayingText = false;
                PauseMenuManager.isPaused = false;
                Time.timeScale = 1f;
                currentDialogueIndex = 0;
                ManagerScen.questStatus = 12;
                dialogueBox.SetActive(false);
            }
        }
        if (ManagerScen.questStatus == 13 && sceneIndex == 8)
        {
            if (currentDialogueIndex < dialoguePoliceman4.Length)
            {
                dialogueText.text = dialoguePoliceman4[currentDialogueIndex];
                currentDialogueIndex++;
            }
            else
            {
                isDisplayingText = false;
                PauseMenuManager.isPaused = false;
                Time.timeScale = 1f;
                currentDialogueIndex = 0;
                ManagerScen.questStatus = 14;
                dialogueBox.SetActive(false);
            }
        }
    }
}

