using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volumechage : MonoBehaviour
{
    public AudioSource audioSource;
    private float musicVolume = 1f;

    private void Start()
    {
        audioSource.Play();
    }
    private void Update()
    {
        audioSource.volume = musicVolume;

    }
    public void updateVolume(float volume)
    {
        musicVolume = volume;
    }
}
