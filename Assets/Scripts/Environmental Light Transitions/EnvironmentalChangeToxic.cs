using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentalChangeToxic : MonoBehaviour
{
    Fade envirChange;

    private void Start()
    {
        //FindsTheCanvas
        envirChange = FindObjectOfType<Canvas>().GetComponent<Fade>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //Fade in ToxicSky
        envirChange.fadeIn(2);


    }
    private void OnTriggerExit(Collider other)
    {
        //Fade in NormalSky
        envirChange.fadeIn(0);
    }
}
