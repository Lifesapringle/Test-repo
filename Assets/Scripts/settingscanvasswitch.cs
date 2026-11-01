using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
public class settingscanvasswitch : MonoBehaviour
{
    public static settingscanvasswitch _;
    [SerializeField] private bool _debugmode;
    [SerializeField] private string _optionsToLoadAfterClickingaudio;
    [SerializeField] private string _optionsToLoadAfterClickinggraphics;
    [SerializeField] private string _optionsToLoadAfterClickingcontrols;
    [SerializeField] private string _optionsToLoadAfterClickingaccessability;

    [SerializeField] private GameObject graphics;
    [SerializeField] private GameObject audio;
    [SerializeField] private GameObject controls;
    [SerializeField] private GameObject accessability;


    public enum canvasswitcher { Graphics, Audio, Controls, Accessability}
    
    public void Awake()
    {
        if (_ == null)
        {
            _ = this;
        }
        else
        {
            Debug.LogError("there is more than 1 settingscanvasswitch inside current scene");
        }
        
    }
    public void Settingsbuttonclicked(canvasswitcher buttonClicked)
    {
        Debugmessage("it works:" + buttonClicked.ToString());
        switch (buttonClicked)
        {
            case canvasswitcher.Graphics:
                graphicsclicked();
                break;
            case canvasswitcher.Audio:
                audioclicked();
                break;
            case canvasswitcher.Controls:
                controlsclicked();
                break;
            case canvasswitcher.Accessability:
                accessabilityclicked();
                break;
            default:
                Debug.Log("Button clicked not added in settingscanvasswitcher");
                break;
                
        }
    }
    private void Debugmessage(string message)
    {
        if (_debugmode)
        {
            Debug.Log(message);
        }
    }
    public void audioclicked()
    {
        audio.SetActive(true);
        graphics.SetActive(false);
        controls.SetActive(false);
        accessability.SetActive(false);
    }
    public void graphicsclicked()
    {
        graphics.SetActive(true);
        audio.SetActive(false);
        controls.SetActive(false);
        accessability.SetActive(false);
    }
    public void controlsclicked()
    {
        controls.SetActive(true);
        graphics.SetActive(false);
        audio.SetActive(false);
        accessability.SetActive(false);
    }
    public void accessabilityclicked()
    {
        accessability.SetActive(true);
        controls.SetActive(false);
        graphics.SetActive(false);
        audio.SetActive(false);
        
    }
}       
