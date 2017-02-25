using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{

    public Slider volumeSliderSFX;
    public Slider volumeSliderMusic;
    public AudioSource volumeAudioSFX;
    public AudioSource volumeAudioVolume;

    public void VolumeController()
    {
        volumeAudioSFX.volume= volumeSliderSFX.value;
        volumeAudioVolume.volume = volumeSliderMusic.value;
    }
}
