using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthDeplete : MonoBehaviour
{

    public GameObject message;

    public Slider bar;

    private float healthPoints = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        bar = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        


        if (healthPoints <= 0)
        {
            message.SetActive(true);


            Destroy(this.gameObject);

        }
    }
}
