using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // Import the SceneManagement namespace

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;

    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime <= 0)
        {     
            remainingTime = 0;
            LoadLoadScreen();  // Load the LoadScreen scene when the timer hits 0
        }

        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void LoadLoadScreen()
    {
        // Load the LoadScreen scene
        SceneManager.LoadScene("LoadScreen"); // Make sure the scene name is correct
    }
}
