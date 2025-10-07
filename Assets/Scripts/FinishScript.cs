using UnityEngine;

public class FinishScript : MonoBehaviour
{
    public GameObject VictoryPanel;
    public bool stopGameOnFinish = true;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Victory();
        }
    }

    private void Victory()
    {
        if (VictoryPanel != null)
        {
            VictoryPanel.SetActive(true);
            
            // Останавливаем время игры если нужно
            if (stopGameOnFinish)
            {
                Time.timeScale = 0f;
            }
        }
    }
}
