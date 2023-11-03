using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressionBarrier : MonoBehaviour
{
    ProgressTracker prog;

    private void OnTriggerEnter(Collider collision)
    {

        prog = GameObject.FindGameObjectWithTag("Master").GetComponent<ProgressTracker>();

        if (prog.part1 || prog.part2)
        {
            Destroy(this.gameObject);
        }
    }
}
