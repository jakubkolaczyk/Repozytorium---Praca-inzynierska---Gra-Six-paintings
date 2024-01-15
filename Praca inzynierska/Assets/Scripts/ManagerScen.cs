using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManagerScen : MonoBehaviour
{
    public static bool isSaved = false;
    public static int questStatus = -1;
    public static bool isLoaded;
    
    // Update is called once per frame
    void Update()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
         if (currentSceneIndex == 0) 
         { 
            Cursor.lockState = CursorLockMode.None;
         }
    }

    void Awake()
    {
        int sceneManagerObjectsCount = FindObjectsOfType<ManagerScen>().Length;
        if (sceneManagerObjectsCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    
}
