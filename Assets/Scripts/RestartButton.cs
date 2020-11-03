using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class RestartButton : MonoBehaviour
{
    public Button but;
    // Start is called before the first frame update
    void Start()
    {
        but.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        print("RestartHit");
        SceneManager.LoadScene("Scene_Main"); //Load scene called Game
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
