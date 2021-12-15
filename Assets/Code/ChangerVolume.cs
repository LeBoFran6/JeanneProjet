using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ChangerVolume : MonoBehaviour
{
    public AudioMixer mixer;

    public void Changervolume (float sliderValue)
    {
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
    }

    public void ChangervolumeSFX(float sliderValue)
    {
        mixer.SetFloat("MusicVolSFX", Mathf.Log10(sliderValue) * 20);
    }
}
