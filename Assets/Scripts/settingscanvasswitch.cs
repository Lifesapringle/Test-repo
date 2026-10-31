using Unity.VisualScripting;
using UnityEngine;
public class settingscanvasswitch : MonoBehaviour
{
    public static settingscanvasswitch _;
    [SerializeField] private bool _debugmode;
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
                break;
            case canvasswitcher.Audio:
                break;
            case canvasswitcher.Controls:
                break;
            case canvasswitcher.Accessability:
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
}
