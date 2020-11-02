using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    private Camera m;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            MazeGame scriptA = Camera.main.GetComponent<MazeGame>();
            scriptA.LifeLost();
            //MazeGame.S.LifeLost();
        }
        print("hi");
    }
}
