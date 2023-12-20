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
    int targetsIndex;

    public float mapSize = 200f; 
    public float arrowSize = 20f;
    private void LateUpdate()
    {
        Vector3 newPosition = player.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;

        //UpdateArrowPosition();
    }

    /*void UpdateArrowPosition()
    {
        targetsIndex = ManagerScen.questStatus - 1;
        // Oblicz kierunek do celu
        Vector3 directionToTarget = (targets[targetsIndex].position - player.position).normalized;

        if (Vector3.Dot(directionToTarget, minimapCamera.transform.forward) > 0)
        {
            // Cel jest widoczny, ustaw pozycjê strza³ki na minimapie
            Vector3 arrowPosition = new Vector3(directionToTarget.x, 0f, directionToTarget.z).normalized * (mapSize / 2f);
            arrow.rectTransform.localPosition = arrowPosition;
            arrow.gameObject.SetActive(true);
        }
        else
        {
            // Cel jest poza widokiem minimapy, ustaw pozycjê strza³ki na brzegu mapy
            Vector3 clampedDirection = Vector3.ClampMagnitude(directionToTarget, mapSize / 2f);
            Vector3 arrowPosition = new Vector3(clampedDirection.x, 0f, clampedDirection.z).normalized * (mapSize / 2f);
            arrow.rectTransform.localPosition = arrowPosition;
            arrow.gameObject.SetActive(true);
        }
    }*/
}
