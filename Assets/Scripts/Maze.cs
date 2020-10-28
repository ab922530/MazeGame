using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Maze : MonoBehaviour
{
    [Header("Set in Inspector")]
    public float rotateSpeed = 10f;

    Rigidbody rb;
   // public GameObject lab;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rotateMaze();
    }

    void rotateMaze()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            print("up");
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            print("down");
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            print("left");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            print("right");
        }
    }
}
