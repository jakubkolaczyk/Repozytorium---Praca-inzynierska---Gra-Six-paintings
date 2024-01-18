using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gallery : MonoBehaviour
{
    public GameObject gallery;
    public GameObject criminal;
    public GameObject policeman;
    void Update()
    {
        if (ManagerScen.questStatus <= 12 && ManagerScen.questStatus >= 10)
        {
            gallery.gameObject.SetActive(true);
            policeman.gameObject.SetActive(true);
            if (ManagerScen.questStatus == 11)
            {
                criminal.gameObject.SetActive(true);
            }
            else
            {
                criminal.gameObject.SetActive(false);
            }
        }
        else
        {
            gallery.gameObject.SetActive(false);
            criminal.gameObject.SetActive(false);
            policeman.gameObject.SetActive(false);
        }
    }
}
