using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float sprintSpeed = 10f;
    public float rotationSpeed = 2f;
    public float jumpForce = 5f;
    public float zoomSpeed = 5f;
    public float zoomFOV = 40f;
    public float normalFOV = 60f;

    public Camera playerCamera;
    private bool isGrounded;
    private bool isSprinting;
    private bool isZoomed;
    [SerializeField]
    Transform character;
    private float sensitivity = 2;
    private float smoothing = 1.5f;

    Vector2 velocity;
    Vector2 frameVelocity;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        // Poruszanie się gracza
        MovePlayer();

        // Skok
        Jump();

        // Zoom kamery
        Zoom();

        //Kamera
        // plynne obroty
        Vector2 mouseDelta = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        Vector2 rawFrameVelocity = Vector2.Scale(mouseDelta, Vector2.one * sensitivity);
        frameVelocity = Vector2.Lerp(frameVelocity, rawFrameVelocity, 1 / smoothing);
        velocity += frameVelocity;
        velocity.y = Mathf.Clamp(velocity.y, -90, 90);

        if (PauseMenuManager.isPaused)
        {
            transform.localRotation = Quaternion.AngleAxis(-velocity.y, Vector3.zero);
            character.localRotation = Quaternion.AngleAxis(velocity.x, Vector3.zero);
        }
        else
        {
            // obroty kamery gra d i prawo lewo
            playerCamera.transform.localRotation = Quaternion.AngleAxis(-velocity.y, Vector3.right);
            transform.localRotation = Quaternion.AngleAxis(velocity.x, Vector3.up);
        }
    }
    

    void MovePlayer()
    {
        isSprinting = Input.GetKey(KeyCode.LeftShift);
        if(isSprinting)
        {
            if (Input.GetKey("w"))
            {
                transform.Translate(Vector3.forward * sprintSpeed * Time.deltaTime);
            }

            // Poruszanie się do tyłu
            if (Input.GetKey("s"))
            {
                transform.Translate(Vector3.back * sprintSpeed * Time.deltaTime);
            }

            // Poruszanie się w lewo
            if (Input.GetKey("a"))
            {
                transform.Translate(Vector3.left * sprintSpeed * Time.deltaTime);
            }

            // Poruszanie się w prawo
            if (Input.GetKey("d"))
            {
                transform.Translate(Vector3.right * sprintSpeed * Time.deltaTime);
            }
        }
        else
        {
            if (Input.GetKey("w"))
            {
                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            }

            // Poruszanie się do tyłu
            if (Input.GetKey("s"))
            {
                transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
            }

            // Poruszanie się w lewo
            if (Input.GetKey("a"))
            {
                transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            }

            // Poruszanie się w prawo
            if (Input.GetKey("d"))
            {
                transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            }
        }        
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void Zoom()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            isZoomed = true;
            playerCamera.fieldOfView = Mathf.Lerp(playerCamera.fieldOfView, zoomFOV, Time.deltaTime * zoomSpeed);
        }
        else
        {
            isZoomed = false;
            playerCamera.fieldOfView = Mathf.Lerp(playerCamera.fieldOfView, normalFOV, Time.deltaTime * zoomSpeed);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = true;
    }
}

