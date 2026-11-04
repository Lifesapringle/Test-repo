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
        switch (mixer)
        {
            case AudioMixMode.LinearAudioSourceVolume;
                AudioSource.volume = Value;
                break;
            case AudioMixMode.LinearMixerVolume:
                Mixer.SetFloat("Volume", (-80 + Value * 100));
                break;
                case AudioMixMode.LogrithmicMixerVolume;
                Mixer.SetFloat("Volume", Mathf.Log10(Value) * 20);
        }
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
