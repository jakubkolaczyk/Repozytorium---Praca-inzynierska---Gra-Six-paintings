using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DrzwiDoPomieszczeń : MonoBehaviour
{
    public TextMeshProUGUI interactText;
    private Vector3 playerStartPosition;
    [SerializeField] private int idDoor;
    private GameObject player;
    private GameObject[] doors;
    private GameObject activeDoor;
    float distance;
    bool canEnter;

    void Start()
    {
        interactText.gameObject.SetActive(false);
        canEnter = false;
        player = GameObject.FindGameObjectWithTag("Player");
        doors = GameObject.FindGameObjectsWithTag("Drzwi");
    }

    void Update()
    {
        ShowInteractText();
        if (idDoor == 1 && canEnter && Input.GetKeyDown(KeyCode.Return))
        {
            SavePlayerPosition();
            SceneManager.LoadScene(4);
        }
        else if (idDoor == 2 && canEnter && Input.GetKeyDown(KeyCode.Return))
        {
            SavePlayerPosition();
            SceneManager.LoadScene(8);
        }
        else if (idDoor == 3 && canEnter && Input.GetKeyDown(KeyCode.Return))
        {
            SavePlayerPosition();
            SceneManager.LoadScene(5);
        }
        else if (idDoor == 4 && canEnter && Input.GetKeyDown(KeyCode.Return))
        {
            SavePlayerPosition();
            SceneManager.LoadScene(6);
        }
        else if (idDoor == 5 && canEnter && Input.GetKeyDown(KeyCode.Return))
        {
            SavePlayerPosition();
            SceneManager.LoadScene(7);
        }
        else if (idDoor == 6 && canEnter && Input.GetKeyDown(KeyCode.Return))
        {
            SavePlayerPosition();
            SceneManager.LoadScene(2);
        }
    }

    void ShowInteractText()
    {
        for (int i = 0; i < doors.Length; i++)
        {
            distance = Vector3.Distance(player.transform.position, doors[i].transform.position);            
            if (distance < 2f)
            {
                activeDoor = doors[i];
            }
        }
        distance = Vector3.Distance(player.transform.position, activeDoor.transform.position);
        if (distance < 2f)
        {
            interactText.gameObject.SetActive(true);
            canEnter = true;
        }
        else
        {
            interactText.gameObject.SetActive(false);
            canEnter = false;
        }
    }
    void SavePlayerPosition()
    {
        playerStartPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
        PlayerPrefs.SetFloat("PlayerPosX", playerStartPosition.x);
        PlayerPrefs.SetFloat("PlayerPosY", playerStartPosition.y);
        PlayerPrefs.SetFloat("PlayerPosZ", playerStartPosition.z);
        PlayerPrefs.Save();
        ManagerScen.isSaved = true;
    }
}
