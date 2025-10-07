using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeToMenu : MonoBehaviour
{
    public GameObject confirmationPanel;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ShowConfirmation();
        }

    }

    private void ShowConfirmation()
    {
        if (confirmationPanel != null)
        {
            confirmationPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    
        public void CancelExit()
    {
        if (confirmationPanel != null)
        {
            confirmationPanel.SetActive(false);
            Time.timeScale = 1f; // Возобновляем игру
        }
    }
}
