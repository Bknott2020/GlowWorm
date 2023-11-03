using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : MonoBehaviour
{

    public GameObject activate, deactivate;

    LaserManagerGame manage;

    void Update()
    {
        activate.SetActive(false);
        deactivate.SetActive(true);
    }

    public void On ()
    {
        activate.SetActive(true);
        deactivate.SetActive(false);

    }

}
