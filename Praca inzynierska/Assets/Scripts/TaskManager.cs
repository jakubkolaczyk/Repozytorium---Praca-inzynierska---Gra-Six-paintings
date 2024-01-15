using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public string[] tasks;
    public TextMeshProUGUI taskText;
    void Update()
    {
        if (ManagerScen.questStatus == 1)
        {
            taskText.text = tasks[0];
        }
        else if (ManagerScen.questStatus == 2)
        {
            taskText.text = tasks[1];
        }
        else if (ManagerScen.questStatus == 3)
        {
            taskText.text = tasks[2];
        }
        else if (ManagerScen.questStatus == 4)
        {
            taskText.text = tasks[3];
        }
        else if (ManagerScen.questStatus == 5)
        {
            taskText.text = tasks[4];
        }
        else if (ManagerScen.questStatus == 6)
        {
            taskText.text = tasks[5];
        }
        else if (ManagerScen.questStatus == 7)
        {
            taskText.text = tasks[6];
        }
        else if (ManagerScen.questStatus == 8)
        {
            taskText.text = tasks[7];
        }
        else if (ManagerScen.questStatus == 9)
        {
            taskText.text = tasks[8];
        }
        else if (ManagerScen.questStatus == 10)
        {
            taskText.text = tasks[9];
        }
        else if (ManagerScen.questStatus == 11)
        {
            taskText.text = tasks[10];
        }
        else if (ManagerScen.questStatus == 12)
        {
            taskText.text = tasks[11];
        }
        else if (ManagerScen.questStatus == 13)
        {
            taskText.text = tasks[12];
        }
        else if (ManagerScen.questStatus == 0)
        {
            taskText.text = tasks[13];
        }
    }
}
