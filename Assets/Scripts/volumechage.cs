using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumechage : MonoBehaviour
{
    public AudioSource audioSource;
    public static float musicVolume = 1f;
    public Slider AudioSlider;

    private void Start()
    {
        audioSource.Play();
        AudioSlider.value = musicVolume;
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
