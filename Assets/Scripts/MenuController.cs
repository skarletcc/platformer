using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("MainGameScene");
        Time.timeScale = 1f;
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
