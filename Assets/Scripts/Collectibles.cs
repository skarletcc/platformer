using UnityEngine;

public class Collect : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Проверяем, что это игрок
        if (other.TryGetComponent<PlayerController>(out var player))
        {
            // Уничтожаем текущий объект
            Destroy(gameObject);
        }
    }
}
