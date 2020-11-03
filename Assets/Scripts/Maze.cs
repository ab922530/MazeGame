using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Maze : MonoBehaviour
{
    [Header("Set in Inspector")]
    public float rotateSpeed = 500f;
    public float rotAngle = 30f;
    Rigidbody rb;
    Vector3 angleVelocityUp;
    Vector3 angleVelocityDown;
    Vector3 angleVelocityLeft;
    Vector3 angleVelocityRight;
    
   

    // public GameObject lab;
    void Start()
    {
        angleVelocityUp = new Vector3(rotateSpeed, 0, 0);
        angleVelocityDown = new Vector3(-rotateSpeed, 0, 0);
        angleVelocityLeft = new Vector3(0, 0, rotateSpeed);
        angleVelocityRight = new Vector3(0, 0, -rotateSpeed);
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
            Vector3 currentRotation = transform.localRotation.eulerAngles;
            currentRotation.y = 0f;
            print(currentRotation.x);
            Mathf.Clamp(currentRotation.x, 0, rotAngle);
            if (currentRotation.x >= 0 + rotAngle || currentRotation.x <= 360 - rotAngle)
            {
                currentRotation.x = currentRotation.x + 1f;
            }
            if (currentRotation.x <= 0 + rotAngle|| currentRotation.x >= 360- rotAngle) { 
            Quaternion deltaRotation = Quaternion.Euler(angleVelocityUp * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
               
            }
            
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 currentRotation = transform.localRotation.eulerAngles;
            currentRotation.y = 0f;
            print(currentRotation.x);
            Mathf.Clamp(currentRotation.x, 0, rotAngle);
            if (currentRotation.x <= 0 + rotAngle || currentRotation.x >= 360 - rotAngle)
            {
                Quaternion deltaRotation = Quaternion.Euler(angleVelocityDown * Time.deltaTime);
                rb.MoveRotation(rb.rotation * deltaRotation);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 currentRotation = transform.localRotation.eulerAngles;
            currentRotation.y = 0f;

            Mathf.Clamp(currentRotation.z, 0, rotAngle);
            if (currentRotation.z >= 0 + rotAngle || currentRotation.z <= 360 - rotAngle)
            {
                currentRotation.z = currentRotation.z + 1f;
            }
            if (currentRotation.z <= 0 + rotAngle || currentRotation.z >= 360 - rotAngle)
            {
                Quaternion deltaRotation = Quaternion.Euler(angleVelocityLeft * Time.deltaTime);
                rb.MoveRotation(rb.rotation * deltaRotation);

            }
           
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 currentRotation = transform.localRotation.eulerAngles;
            currentRotation.y = 0f;

            Mathf.Clamp(currentRotation.z, 0, rotAngle);
         
            if (currentRotation.z <= 0 + rotAngle || currentRotation.z >= 360 - rotAngle)
            {
                Quaternion deltaRotation = Quaternion.Euler(angleVelocityRight * Time.deltaTime);
                rb.MoveRotation(rb.rotation * deltaRotation);

            }
        }
    }
}
