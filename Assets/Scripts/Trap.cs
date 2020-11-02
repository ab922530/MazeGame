using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    private Camera m;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider coll)
    {
        MazeGame scriptA = Camera.main.GetComponent<MazeGame>();
        scriptA.lostLife();
    
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
