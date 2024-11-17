using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene loading

public class SceneTimer : MonoBehaviour
{
    // Time in seconds before the scene changes
    public float delay = 32f;

    // The name of the scene you want to load
    public string nextSceneName;

    void Start()
    {
        // Start a coroutine to wait for the delay before changing scenes
        StartCoroutine(ChangeSceneAfterDelay());
    }

    // Coroutine to handle the scene change after the specified delay
    private System.Collections.IEnumerator ChangeSceneAfterDelay()
    {
        // Wait for the specified number of seconds
        yield return new WaitForSeconds(delay);

        // Load the next scene
        SceneManager.LoadScene(nextSceneName);
    }
}