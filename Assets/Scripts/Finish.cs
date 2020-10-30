using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    static public bool finishMet = false;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            Finish.finishMet = true;
        }
        print("hi");
    }
}
