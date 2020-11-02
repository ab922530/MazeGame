using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    private Camera m;

    void OnTriggerEnter(Collider other)
    {
        // MazeGame.S.LifeLost();
        MazeGame scriptA = Camera.main.GetComponent<MazeGame>();
        scriptA.LifeLost();
    }
}
