using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 startPos;
    public Rigidbody RB;


    //Go to the maze's starting position
    void GoToStart()
    {
        transform.position = startPos;
        RB.velocity = Vector3.zero;
    }

    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (transform.position.y < -20)
            GoToStart();
    }
}