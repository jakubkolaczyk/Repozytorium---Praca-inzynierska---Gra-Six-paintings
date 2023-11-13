using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManagerScen : MonoBehaviour
{
    public GameObject canvas;

    void Start()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        /*if (currentSceneIndex != 0)
        {
            canvas.gameObject.SetActive(false);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex != 0)
        {
            if (Input.GetKey(KeyCode.Escape)) 
            { 
                SceneManager.LoadScene(0);
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }

    void Awake()
    {
        if (FindObjectOfType<ManagerScen>() == null)
            DontDestroyOnLoad(this.gameObject);
        else
        {
            Destroy(this.gameObject);
        }
    }
}
