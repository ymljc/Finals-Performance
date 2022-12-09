using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    public AudioSource SFX;
    public Slider volumeSlider;
    private float MusicVolume = 1f;

    void Start()
    {
        MusicVolume = PlayerPrefs.GetFloat("volumeSfx");
        SFX.volume = MusicVolume;
        volumeSlider.value = MusicVolume;
    }

    void Update()
    {
        SFX.volume = MusicVolume;
        PlayerPrefs.SetFloat("volumeSfx", MusicVolume);
    }

    public void VolumeUpdater(float volume)
    {
        MusicVolume = volume;
    }
}