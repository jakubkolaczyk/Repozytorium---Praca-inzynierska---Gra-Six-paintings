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
    public TextMeshProUGUI dialogueName;
    void Start()
    {
        dialogueBox.SetActive(false);
        player = GameObject.FindGameObjectWithTag("Player");       
    }

    void Update()
    {
        if (ManagerScen.questStatus == 1 || ManagerScen.questStatus == 5 || ManagerScen.questStatus == 7 
            || ManagerScen.questStatus == 9 || ManagerScen.questStatus == 10 || ManagerScen.questStatus == 13)
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

        if (ManagerScen.questStatus == 7)
        {
            dialogueName.text = "Policeman Jack";
        }
        else if (ManagerScen.questStatus == 11)
        {
            dialogueName.text = "Criminal";
        }
    }


    void ShowNextDialogue()
    {
        if (ManagerScen.questStatus==1 && sceneIndex == 8)
        {
            DisplayDialogue(dialoguePoliceman1);
        }

        if (ManagerScen.questStatus == 2 && sceneIndex == 5)
        {
            DisplayDialogue(dialogueShopkeeper);
        }
        if (ManagerScen.questStatus == 3 && sceneIndex == 4)
        {          
            DisplayDialogue(dialogueDoctor);
        }
        if (ManagerScen.questStatus == 5 && sceneIndex == 8)
        {
            DisplayDialogue(dialoguePoliceman2);
        }
        if (ManagerScen.questStatus == 6 && sceneIndex == 7)
        {
            DisplayDialogue(dialogueGarden);
        }
        if (ManagerScen.questStatus == 7 && sceneIndex == 7)
        {
            DisplayDialogue(dialogueGarden2);
        }
        if (ManagerScen.questStatus == 8 && sceneIndex == 6)
        {
            DisplayDialogue(dialogueWorkshop);
        }
        if (ManagerScen.questStatus == 9 && sceneIndex == 8)
        {
            DisplayDialogue(dialoguePoliceman3);
        }
        if (ManagerScen.questStatus == 10 && sceneIndex == 1)
        {
            DisplayDialogue(dialogueTown);
        }
        if (ManagerScen.questStatus == 11 && sceneIndex == 1)
        {
            DisplayDialogue(dialogueTown2);
        }
        if (ManagerScen.questStatus == 13 && sceneIndex == 8)
        {            
            DisplayDialogue(dialoguePoliceman4);
        }
    }

    void ShowNextSentence()
    {
        if (ManagerScen.questStatus == 1 && sceneIndex == 8)
        {            
            DisplaySentence(dialoguePoliceman1, 2);
        }

        if (ManagerScen.questStatus == 2 && sceneIndex == 5)
        {
            DisplaySentence(dialogueShopkeeper, 3);
        }
        if (ManagerScen.questStatus == 3 && sceneIndex == 4)
        {
            DisplaySentence(dialogueDoctor, 4);
        }
        if (ManagerScen.questStatus == 5 && sceneIndex == 8)
        {
            DisplaySentence(dialoguePoliceman2, 6);
        }
        if (ManagerScen.questStatus == 6 && sceneIndex == 7)
        {
            DisplaySentence(dialogueGarden, 7);
        }
        if (ManagerScen.questStatus == 7 && sceneIndex == 7)
        {
            DisplaySentence(dialogueGarden2, 8);
        }
        if (ManagerScen.questStatus == 8 && sceneIndex == 6)
        {
            DisplaySentence(dialogueWorkshop, 9);
        }
        if (ManagerScen.questStatus == 9 && sceneIndex == 8)
        {
            DisplaySentence(dialoguePoliceman3, 10);
        }
        if (ManagerScen.questStatus == 10 && sceneIndex == 1)
        {
            DisplaySentence(dialogueTown, 11);
        }
        if (ManagerScen.questStatus == 11 && sceneIndex == 1)
        {
            DisplaySentence(dialogueTown2, 12);
        }
        if (ManagerScen.questStatus == 13 && sceneIndex == 8)
        {            
            DisplaySentence(dialoguePoliceman4, 14);
        }
    }
    public void DisplayDialogue(string[] dialogue)
    {
        if (currentDialogueIndex < dialogue.Length)
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
    public void DisplaySentence(string[] dialogue, int quest)
    {
        if (currentDialogueIndex < dialogue.Length)
        {
            dialogueText.text = dialogue[currentDialogueIndex];
            currentDialogueIndex++;
        }
        else
        {
            isDisplayingText = false;
            PauseMenuManager.isPaused = false;
            Time.timeScale = 1f;
            currentDialogueIndex = 0;
            ManagerScen.questStatus = quest;
            dialogueBox.SetActive(false);
        }
    }
}

