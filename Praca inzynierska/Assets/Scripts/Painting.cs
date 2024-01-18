using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour
{
    public GameObject painting;

    // Update is called once per frame
    void Update()
    {
        if (ManagerScen.questStatus >= 13)
        {
            painting.gameObject.SetActive(true);
        }
        else
        {
            painting.gameObject.SetActive(false);
        }
    }
}
