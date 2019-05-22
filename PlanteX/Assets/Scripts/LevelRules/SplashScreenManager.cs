using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class SplashScreenManager : MonoBehaviour
{
    public VideoClip VideoClip;

    void Start()
    {
        VideoPlayer videoPlayer = gameObject.AddComponent<VideoPlayer>();
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();

        videoPlayer.playOnAwake = false;
        audioSource.playOnAwake = false;
        videoPlayer.clip = VideoClip;
        videoPlayer.isLooping = true;
        videoPlayer.renderMode = VideoRenderMode.CameraFarPlane;
        videoPlayer.targetCamera = GameObject.FindObjectOfType<Camera>();
        videoPlayer.aspectRatio = VideoAspectRatio.Stretch;
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.SetTargetAudioSource(0, audioSource);

        videoPlayer.prepareCompleted += (source) => videoPlayer.Play();

        videoPlayer.Prepare();
    }

    void Update()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene("startmenu");
        }
    }
}
