using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class SplashScreenManager : MonoBehaviour
{
    public MovieTexture SplashScreenTexture;
    private AudioSource audio;

    void Start()
    {
        GetComponent<RawImage>().texture = SplashScreenTexture as MovieTexture;
        audio = GetComponent<AudioSource>();
        audio.clip = SplashScreenTexture.audioClip;

        SplashScreenTexture.Play();
        audio.Play();
    }

    void Update()
    {
        if (!SplashScreenTexture.isPlaying)
        {
            Application.LoadLevel(1);
        }
    }
}
