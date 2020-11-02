using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < -20)
            MazeGame.S.LifeLost();
    }
}