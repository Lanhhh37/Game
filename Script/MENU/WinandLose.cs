using UnityEngine;
using UnityEngine.SceneManagement;

public class WinandLose : MonoBehaviour
{
    public GameObject loseMenu;
    public GameObject winMenu;
    private int enemyCount;

    private void OnEnable()
    {
        CastleHealth.OnCastleDeath += EnableLoseMenu;
    }

    private void OnDisable()
    {
        CastleHealth.OnCastleDeath -= EnableLoseMenu;
    }


    public void EnableLoseMenu()
    {
        loseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void EnableWinMenu()
    {
        winMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
