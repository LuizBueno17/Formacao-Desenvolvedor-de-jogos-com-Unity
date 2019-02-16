using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class ControleDoMixer : MonoBehaviour
{
    [SerializeField]
    private AudioMixer mixer;
    [SerializeField]
    private string parametroDoMixer;
    private Slider[] sliders;
    private void Awake()
    {
        sliders = FindObjectsOfType<Slider>();
    }
    private void Start()
    {
        if (PlayerPrefs.HasKey(this.parametroDoMixer))
        {
            var volume = PlayerPrefs.GetFloat(this.parametroDoMixer);
            this.mixer.SetFloat(this.parametroDoMixer, volume);
            SetSliderValue(volume, this.parametroDoMixer);
        }
        else
        {
            this.mixer.SetFloat(this.parametroDoMixer, 0);
        }
    }

    private void SetSliderValue(float volume, string parametroDoMixer)
    {
        foreach (var slider in sliders)
        {
            if(slider.tag == parametroDoMixer){
                slider.value = volume;
                return;
            }
        }
    }

    public void MudarVolume(float volume)
    {
        this.mixer.SetFloat(this.parametroDoMixer, volume);
        PlayerPrefs.SetFloat(this.parametroDoMixer, volume);
    }
}
