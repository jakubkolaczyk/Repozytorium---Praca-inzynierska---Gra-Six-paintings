using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniMapFollow : MonoBehaviour
{
    public Transform player;
    public Transform[] targets;
    public Camera minimapCamera;
    public RawImage arrow;

    public float mapSize = 200f; 
    public float arrowSize = 20f;
    private void LateUpdate()
    {
        Vector3 newPosition = player.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;
    }
}
