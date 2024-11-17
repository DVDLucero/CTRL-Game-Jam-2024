using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbienceSound : MonoBehaviour
{

    public GameObject mainCamera;

    public AK.Wwise.Event musicCalm;
    public AK.Wwise.Event musicActive;

    public AK.Wwise.Event bird;
    public AK.Wwise.Event wind;

    public AK.Wwise.Event stopAmbience;
    public AK.Wwise.Event stopMusic;

    void Start() {
        PlayAmbience();
        PlayMusicAcitve();
    }

    public void PlayAmbience() {
        wind.Post(mainCamera);
        StartCoroutine(PlayBirdSound());
    }

    private IEnumerator PlayBirdSound() {
        int playDelay = Random.Range(1,25);
        yield return new WaitForSeconds(playDelay);
    }

    public void PlayMusicAcitve() {
        StopMusic();
        musicActive.Post(mainCamera);
    }

    public void PlayMusicCalm() {
        StopMusic();
        musicCalm.Post(mainCamera);
    }

    public void StopAmbience() {
        stopAmbience.Post(mainCamera);
    }   

    public void StopMusic() {
        stopMusic.Post(mainCamera);
    }

}
