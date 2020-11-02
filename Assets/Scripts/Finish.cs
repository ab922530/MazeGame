using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public static bool finishMet = false;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            finishMet = true;
        }
        print("hi");
    }
}
