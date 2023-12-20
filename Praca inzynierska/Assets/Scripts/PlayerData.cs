using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class PlayerData
{
    public int questSave;
    public int sceneSave;
    public float[] playerPosisionSave;

    public PlayerData (PlayerController player)
    {
        questSave = ManagerScen.questStatus;
        sceneSave = player.sceneIndex;

        playerPosisionSave = new float[3];
        playerPosisionSave[0] = player.transform.position.x;
        playerPosisionSave[1] = player.transform.position.y;
        playerPosisionSave[2] = player.transform.position.z;
    }
}
