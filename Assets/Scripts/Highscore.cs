using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Highscore : MonoBehaviour
{
    public static int highestLevel = 2;
    public static float fastestTime = 20000f;

    void Awake()
    {
        // If the PlayerPrefs Highest Level already exists, read it
        if (PlayerPrefs.HasKey("Highest Level"))
            highestLevel = PlayerPrefs.GetInt("Highest Level");

        // If the PlayerPrefs fastest already exists, read it
        if (PlayerPrefs.HasKey("Fastest Time"))
            highestLevel = PlayerPrefs.GetInt("Fastest Time");

        // Assign the high scores to Highest Level and Fastest Time
        PlayerPrefs.SetInt("Highest Level", 2);
        PlayerPrefs.SetFloat("Fastest Time", fastestTime);
    }

    public static void CheckScoreBeaten()
    {
        int level = MazeGame.level;
        float time = MazeGame.S.time;
        if (level >= PlayerPrefs.GetInt("Highest Level"))
        {
            PlayerPrefs.SetInt("Highest Level", highestLevel);

            if (level > PlayerPrefs.GetInt("Highest Level") &&
              time < PlayerPrefs.GetFloat("Fastest Time"))
                PlayerPrefs.SetFloat("Fastest Time", time);
        }

        highestLevel = PlayerPrefs.GetInt("Highest Level");
        fastestTime = PlayerPrefs.GetFloat("Fastest Time");
    }
}