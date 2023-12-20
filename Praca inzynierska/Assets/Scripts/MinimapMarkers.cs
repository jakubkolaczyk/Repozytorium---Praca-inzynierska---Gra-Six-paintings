using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapMarkers : MonoBehaviour
{
    public Transform minimapCamera;
    public float minimapSize = 200f;
    Vector3 tempV3;
    
    // Update is called once per frame
    void Update()
    {
        tempV3 = transform.parent.transform.position;
        tempV3.y = transform.position.y;
        transform.position = tempV3;
    }

    private void LateUpdate()
    {
        float clampedX = Mathf.Clamp(transform.position.x, minimapCamera.position.x - minimapSize, minimapSize + minimapCamera.position.x);
        float clampedZ = Mathf.Clamp(transform.position.z, minimapCamera.position.z - minimapSize, minimapSize + minimapCamera.position.z);
        transform.position = new Vector3(clampedX, transform.position.y, clampedZ);
    }
}
