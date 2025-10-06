using UnityEngine;

public class Collect : MonoBehaviour
{
    [SerializeField] private int pointsValue = 1;

    [System.Obsolete]
    void OnTriggerEnter(Collider other)
    {
        // Проверяем, что это игрок
        if (other.CompareTag("Player"))
        {
            ScoreScript scoreManager = FindObjectOfType<ScoreScript>();
            if (scoreManager != null)
            {
                scoreManager.AddPoints(pointsValue);
            }
            // Уничтожаем текущий объект
            Destroy(gameObject);
        }
    }
}
