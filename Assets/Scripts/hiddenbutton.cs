using UnityEngine;
using UnityEngine.SceneManagement;

public class hiddenbutton : MonoBehaviour
{
    [SerializeField] private GameObject mainmenu;
    [SerializeField] private GameObject Settings;
    public void OpenMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void Quitgame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

    public void opensettings()
    {
        mainmenu.SetActive(false);
        Settings.SetActive(true);
    }

    public void closesettings()
    {
        Settings.SetActive(false);
        mainmenu.SetActive(true);
    }
}
