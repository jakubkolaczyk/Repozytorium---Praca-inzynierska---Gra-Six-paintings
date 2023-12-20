using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkersManagment : MonoBehaviour
{
    int x;
    public GameObject markerKomisariat;
    public GameObject markerSklep;
    public GameObject markerDom;
    public GameObject markerBiuro;
    public GameObject markerOgrod;
    public GameObject markerPracownia;
    public GameObject markerRynek;
    // Update is called once per frame
    void Update()
    {
        x = ManagerScen.questStatus;
        if (x == 1 || x == 5 || x == 9 || x == 13)
        {
            markerKomisariat.SetActive(true);
        }
        else
        {
            markerKomisariat.SetActive(false);
        }
        if (x == 2)
        {
            markerSklep.SetActive(true);
        }
        else
        {
            markerSklep.SetActive(false);
        }
        if (x == 3)
        {
            markerDom.SetActive(true);
        }
        else
        {
            markerDom.SetActive(false);
        }
        if (x == 4 || x == 12)
        {
            markerBiuro.SetActive(true);
        }
        else
        {
            markerBiuro.SetActive(false);
        }
        if (x == 6)
        {
            markerOgrod.SetActive(true);
        }
        else
        {
            markerOgrod.SetActive(false);
        }
        if (x == 8)
        {
            markerPracownia.SetActive(true);
        }
        else
        {
            markerPracownia.SetActive(false);
        }
        if (x == 10)
        {
            markerRynek.SetActive(true);
        }
        else
        {
            markerRynek.SetActive(false);
        }
    }
}
