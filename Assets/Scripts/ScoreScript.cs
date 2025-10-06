using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public int CurrentScore = 0;

    public void AddPoints(int points)
    {
        CurrentScore += points;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        ScoreText.text = "Очки: " + CurrentScore;
    }

    void Update()
    {
        // Каждый кадр обновляем текст на экране
        ScoreText.text = "Очки: " + CurrentScore;
    }
}
