using UnityEngine;

public class settingsbuttonmanager : MonoBehaviour
{
    [SerializeField] private settingscanvasswitch.canvasswitcher _buttonType;
    public void ButtonClicked()
    {
        settingscanvasswitch._.Settingsbuttonclicked(_buttonType);
    }
}
