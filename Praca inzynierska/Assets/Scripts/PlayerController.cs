﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 4f;
    public float sprintSpeed = 7f;
    public float rotationSpeed = 2f;
    public float zoomSpeed = 5f;
    public float zoomFOV = 40f;
    public float normalFOV = 60f;

    public Camera playerCamera;
    private bool isSprinting;
    [SerializeField]
    Transform character;
    private float sensitivity = 2;
    private float smoothing = 1.5f;

    Vector2 velocity;
    Vector2 frameVelocity;

    public int sceneIndex;

    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1 && ManagerScen.isSaved)
        {
            float playerPosX = PlayerPrefs.GetFloat("PlayerPosX");
            float playerPosY = PlayerPrefs.GetFloat("PlayerPosY");
            float playerPosZ = PlayerPrefs.GetFloat("PlayerPosZ");

            Vector3 playerPosition = new Vector3(playerPosX, playerPosY, playerPosZ);
            transform.position = playerPosition;
            ManagerScen.isSaved = false;
        }
        if (PauseMenuManager.isPaused==false)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }

        
        
    }
    void Update()
    {
        // Poruszanie się gracza
        MovePlayer();

        // Zoom kamery
        Zoom();

        //Kamera
        if (PauseMenuManager.isPaused==false)
        {
            // plynne obroty
            Vector2 mouseDelta = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
            Vector2 rawFrameVelocity = Vector2.Scale(mouseDelta, Vector2.one * sensitivity);
            frameVelocity = Vector2.Lerp(frameVelocity, rawFrameVelocity, 1 / smoothing);
            velocity += frameVelocity;
            velocity.y = Mathf.Clamp(velocity.y, -90, 90);

            // obroty kamery gra d i prawo lewo
            playerCamera.transform.localRotation = Quaternion.AngleAxis(-velocity.y, Vector3.right);
            transform.localRotation = Quaternion.AngleAxis(velocity.x, Vector3.up);
        }
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        
    }
    

    void MovePlayer()
    {
        isSprinting = Input.GetKey(KeyCode.LeftShift);
        float speed;
        if(isSprinting)
        {
            speed = sprintSpeed;            
        }
        else
        {
            speed = moveSpeed;            
        }

        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    void Zoom()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            playerCamera.fieldOfView = Mathf.Lerp(playerCamera.fieldOfView, zoomFOV, Time.deltaTime * zoomSpeed);
        }
        else
        {
            playerCamera.fieldOfView = Mathf.Lerp(playerCamera.fieldOfView, normalFOV, Time.deltaTime * zoomSpeed);
        }
    }

    public void SavePlayer()
    {
        SaveSystem.SaveData(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadData(this);

        ManagerScen.questStatus = data.questSave;
        int scene = data.sceneSave;
        SceneManager.LoadScene(scene);        
    }
}

