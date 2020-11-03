using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        cameraFollow();
        if (transform.position.y < -20)
            MazeGame.S.LifeLost();
    }

    void cameraFollow()
    {
        float charPosX = transform.position.x;
        float charPosZ = transform.position.z - 12;
        float cameraOffset = 30.0f;

        Camera.main.transform.position = new Vector3(charPosX, cameraOffset, charPosZ);

    }
}