using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer.Play(); // Start video playback
    }

    public void PauseVideo()
    {
        videoPlayer.Pause();
    }

    public void PlayVideo()
    {
        videoPlayer.Play();
    }
}