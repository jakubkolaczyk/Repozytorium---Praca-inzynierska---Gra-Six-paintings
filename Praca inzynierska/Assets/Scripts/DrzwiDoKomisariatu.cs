using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DrzwiDoKomisariatu : MonoBehaviour
{
    public TextMeshProUGUI interactText;
    bool komisariat;
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
            komisariat = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactText.gameObject.SetActive(false);
            komisariat = false;
        }
    }

    void Update()
    {
        if (interactText.gameObject.activeSelf && Input.GetKeyDown(KeyCode.Return) && komisariat)
        {
            playerStartPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
            PlayerPrefs.SetFloat("PlayerPosX", playerStartPosition.x);
            PlayerPrefs.SetFloat("PlayerPosY", playerStartPosition.y);
            PlayerPrefs.SetFloat("PlayerPosZ", playerStartPosition.z);
            PlayerPrefs.Save();
            ManagerScen.isSaved = true;
            SceneManager.LoadScene(8);
        }
    }
}
