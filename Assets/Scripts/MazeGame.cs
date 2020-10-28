using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MazeGame : MonoBehaviour
{
    public static MazeGame S; // a private Singleton


    [Header("Set in Inspector")]

    public Text uiLevel; // The UILevel Text
    public Text uiTime; // The UITime Text
    public Text uiFastest; // The UIFastest Text
    public Text uiLives; // The Text on UILives
    public GameObject[] mazes;   // An array of the castles


    [Header("Set Dynamically")]

    public static int level; // The current level
    public int levelMax; // The number of levels
    public float time; // Time elapsed
    public GameObject maze; // The current maze


    // Start is called before the first frame update
    void Start()
    {
        S = this; // Define the Singleton
        level = 0;
        levelMax = mazes.Length;
        StartLevel();
    }


    void StartLevel()
    {
        // Get rid of the old castle if one exists
        if (maze != null)
        {
            Destroy(maze);
        }
        
        // Find start time


        // Instantiate the new maze
        maze = Instantiate<GameObject>(mazes[level]);
        maze.transform.position = Vector3.zero;
        time = 0f;

        UpdateGUI();
    }

    void UpdateGUI()
    {
        // Show the data in the GUITexts
        uiLevel.text = "Level: " + (level + 1) + " of " + levelMax;
        uiTime.text = "Time: " + time;
        uiFastest.text = "Fastest: "; // + fastest;
    }
    
    // Update is called once per frame
    void Update()
    {
        // Calculate time elapsed


        UpdateGUI();
    }
}
