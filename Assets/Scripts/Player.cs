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
        float charPosX = transform.position.x + 17;
        float charPosZ = transform.position.z - 15;
        float cameraOffset = 25.0f;

        Camera.main.transform.position = new Vector3(charPosX, cameraOffset, charPosZ);

    }
}