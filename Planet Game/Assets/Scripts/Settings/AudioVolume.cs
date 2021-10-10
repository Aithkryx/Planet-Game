using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioVolume : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetVolumeMaster(float sliderValue)
    {
        Debug.Log(sliderValue);
        mixer.SetFloat("VolumeMaster", Mathf.Log10(sliderValue) * 20);
    }

    public void SetVolumeMusic(float sliderValue)
    {
        Debug.Log(sliderValue);
        mixer.SetFloat("VolumeMusic", Mathf.Log10(sliderValue) * 20);
    }

    public void SetVolumeAmbiance(float sliderValue)
    {
        Debug.Log(sliderValue);
        mixer.SetFloat("VolumeAmbiance", Mathf.Log10(sliderValue) * 20);
    }
}
