using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChucNangMenu : MonoBehaviour
{
    public void PLAY()
    {
        SceneManager.LoadScene(1);
    }

    public void EXIT()
    {
        Application.Quit();
    }

    public void MENUBACK()
    {
        SceneManager.LoadScene(0);
    }

    public void PLAY1()
    {
        SceneManager.LoadScene(2);
    }

    public void PLAY2()
    {
        SceneManager.LoadScene(0);
    }
    public void PLAY3()
    {
        SceneManager.LoadScene(0);
    }
}
