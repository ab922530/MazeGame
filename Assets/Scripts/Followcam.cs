using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followcam : MonoBehaviour
{
    [Header("Set in Inspector")]

    public float easing = 0.05f;
    public float test = 0f;
    public Vector2 minXY = Vector2.zero;

    [Header("Set Dynamically")]
    public GameObject POI;
    public float camZ;

    void Start()
    {
        POI = GameObject.FindWithTag("Player");
    }

    void Awake()
    {
        camZ = this.transform.position.z;
    }

    void FixedUpdate()
    {
        POI = GameObject.FindWithTag("Player");

        Vector3 destination;
        if (POI == null)
        {
            destination = Vector3.zero;
        }
        else
        {
           
            destination = POI.transform.position;


            if (POI.tag == "Player")
            {
                if (POI.GetComponent<Rigidbody>().IsSleeping())
                {
                    POI = null;
                    return;
                }
            }
        }

        transform.LookAt(POI.transform,Vector3.up);

    }
}
