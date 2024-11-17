using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        // Loads the next scene in the build index
        SceneManager.LoadScene("Video");
    }

    public void Quit()
    {
        // Quits the application
        Application.Quit();
        Debug.Log("Player has Quit the Game!"); // Fixed capitalization
    }
}