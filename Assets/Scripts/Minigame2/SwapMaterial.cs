using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapMaterial : MonoBehaviour
{

    public Material normal, wrong;

    private void Start()
    {

        this.gameObject.GetComponent<MeshRenderer>().material = normal;

    }


    public void Swap()
    {

        this.gameObject.GetComponent<MeshRenderer>().material = wrong;


    }


}
