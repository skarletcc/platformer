using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class HeartScript : MonoBehaviour
{
    public Image Heart1;
    public Image Heart2;
    public Image Heart3;
    public int CurrentHearts;

    private void Start()
    {
        CurrentHearts = 3;
    }

    public void RemoveHeart()
    {
        if (CurrentHearts > 0)
        {
            CurrentHearts--;
            UpdateHearts();
            
            if (CurrentHearts <= 0)
            {
                GameOver();
            }
        }
    }

    private void UpdateHearts()
    {
        switch (CurrentHearts)
        {
            case 3:
                Heart1.enabled = true;
                Heart2.enabled = true;
                Heart3.enabled = true;
                break;
            case 2:
                Heart1.enabled = true;
                Heart2.enabled = true;
                Heart3.enabled = false;
                break;
            case 1:
                Heart1.enabled = true;
                Heart2.enabled = false;
                Heart3.enabled = false;
                break;
            case 0:
                Heart1.enabled = false;
                Heart2.enabled = false;
                Heart3.enabled = false;
                break;
        }

    }
    private void GameOver()
    {
        Time.timeScale = 0f;
        Debug.Log("Игра окончена");
        SceneManager.LoadScene("GameOver");
    }
}
