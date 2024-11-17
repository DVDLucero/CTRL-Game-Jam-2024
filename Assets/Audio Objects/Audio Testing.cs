using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioTesting : MonoBehaviour
{
    public GameObject soundSource;
    public AK.Wwise.Event soundTest;
    public void PlayGrunt() {
        soundTest.Post(soundSource);
    }

    public void LoadNorthAfricaLevel() //Change North Africa For whatever place needed.
    {
        SceneManager.LoadScene("SampleScene");
    }
}
