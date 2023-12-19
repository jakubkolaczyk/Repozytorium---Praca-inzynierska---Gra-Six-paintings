using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class DrzwiDoBiura : MonoBehaviour
{ 
    public TextMeshProUGUI interactText;
    bool biuro;
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
            biuro = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactText.gameObject.SetActive(false);
            biuro = false;
        }
    }

    void Update()
    {
        if (interactText.gameObject.activeSelf && Input.GetKeyDown(KeyCode.Return) && biuro)
        {
            playerStartPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
            PlayerPrefs.SetFloat("PlayerPosX", playerStartPosition.x);
            PlayerPrefs.SetFloat("PlayerPosY", playerStartPosition.y);
            PlayerPrefs.SetFloat("PlayerPosZ", playerStartPosition.z);
            PlayerPrefs.Save();
            ManagerScen.isSaved = true;
            SceneManager.LoadScene(2);
        }
    }
}
