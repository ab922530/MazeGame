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
    public int lives = 3;
    public GameObject[] mazes;   // An array of the mazes


    [Header("Set Dynamically")]

    public static int level; // The current level
    private int levelMax; // The number of levels
    private GameObject maze; // The current maze
    private float startTime; // Time when level starts
    public float time; // Time elapsed


    // Start is called before the first frame update
    void Start()
    {
        S = this; // Define the Singleton
        level = 0;
        levelMax = mazes.Length;

        // Find start time
        startTime = Time.time;

        StartLevel();
    }

    // Update is called once per frame
    void Update()
    {
        time = Time.time - startTime; // Calculate time elapsed

        // Start next level if last one beaten
        if (Finish.finishMet == true)
            Invoke("NextLevel", 2f);
        RewriteUI();
    }

    public void LifeLost()
    {
        StartLevel();
        lives--;
    }

    void StartLevel()
    {
        // Get rid of the old maze if one exists
        if (maze != null)
        {
            Destroy(maze);
        }

        // Instantiate the new maze
        maze = Instantiate<GameObject>(mazes[level]);
        maze.transform.position = Vector3.zero;

        Finish.finishMet = false;
        RewriteUI();
    }

    void RewriteUI()
    {
        // Show the data in the GUITexts
        uiFastest.text = "Fastest: "; // + fastest;
        uiLevel.text = "Level: " + (level + 1) + " of " + levelMax;
        uiTime.text = "Lives: " + lives;
        uiTime.text = "Time: " + time.ToString("F1") + " Seconds";
    }
    
    void NextLevel()
    {
        Highscore.CheckScoreBeaten();

        if (++level == levelMax)
            level = 0;

        StartLevel();
    }
}