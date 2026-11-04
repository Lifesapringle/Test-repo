using UnityEngine;
using TMPro;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;
public class settingsmenu : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider Volumeslider;
    [SerializeField] private AudioMixer Mixer;
    [SerializeField] private AudioSource AudioSource;
    [SerializeField] private AudioMixMode Mixing;

    public void OnChangeSlider(float Value)
    {
        
    }

    public enum AudioMixMode
    {
        LinearAudioSourceVolume,
        LinearMixerVolume,
        LogrithmicMixerVolume
    }
    void Start()
    {
        Volumeslider.onValueChanged.AddListener(SetVolume);
        loadsetting();

    }

    void loadsetting()
    {
        float volume = PlayerPrefs.GetFloat("volume");

        SetVolume(volume);
    }

    public void SetVolume(float value)
    {
        mixer.SetFloat("Volume", value);
        Volumeslider.value = value;
        PlayerPrefs.SetFloat("volume", value);
    }
}
