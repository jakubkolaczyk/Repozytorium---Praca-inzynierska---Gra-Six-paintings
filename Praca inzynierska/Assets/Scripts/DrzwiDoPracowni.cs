using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DrzwiDoPracowni : MonoBehaviour
{
    public TextMeshProUGUI interactText;
    bool pracownia;
    private Vector3 playerStartPosition;
    private void Start()
    {
        interactText.gameObject.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactText.gameObject.SetActive(true);
            pracownia = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactText.gameObject.SetActive(false);
            pracownia = false; 
        }
    }

    void Update()
    {
        if (interactText.gameObject.activeSelf && Input.GetKeyDown(KeyCode.Return) && pracownia)
        {
            playerStartPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
            PlayerPrefs.SetFloat("PlayerPosX", playerStartPosition.x);
            PlayerPrefs.SetFloat("PlayerPosY", playerStartPosition.y);
            PlayerPrefs.SetFloat("PlayerPosZ", playerStartPosition.z);
            PlayerPrefs.Save();
            ManagerScen.isSaved = true;
            SceneManager.LoadScene(6);
        }
    }
}
