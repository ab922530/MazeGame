using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 startPos;
    public Rigidbody RB;
   
    private Maze m;


    //Go to the maze's starting position
    void GoToStart()
    {
        transform.position = startPos;
        RB.velocity = Vector3.zero;
        print("Attempting to call reset maze");
        GameObject ma = GameObject.FindWithTag("maze");
        m = ma.GetComponent<Maze>();
        m.ResetMaze();

    }

    void Start()
    {
        
        RB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (transform.position.y < -20)
        {
            GoToStart();
            
            

        }
    }
}