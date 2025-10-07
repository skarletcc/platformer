using UnityEngine;

public class DeathScript : MonoBehaviour
{
[Tooltip("Начальная точка возрождения игрока. Если не назначена, будет использоваться позиция (0,0,0)")]
    public Transform respawnPoint;

    private void Start()
    {
        // Если точка возрождения не назначена в инспекторе, создаем её в позиции (0,0,0)
        if (respawnPoint == null)
        {
            GameObject defaultRespawn = new GameObject("DefaultRespawnPoint");
            respawnPoint = defaultRespawn.transform;
            respawnPoint.position = Vector3.zero;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HeartScript playerHealth = other.GetComponent<HeartScript>();
            
            if (playerHealth != null)
            {
                playerHealth.RemoveHeart();
            }
            RespawnPlayer(other.gameObject);
        }
    }

    private void RespawnPlayer(GameObject player)
    {
        // Получаем компонент CharacterController (если есть) для временного отключения
        CharacterController characterController = player.GetComponent<CharacterController>();
        bool wasEnabled = false;
        
        if (characterController != null)
        {
            wasEnabled = characterController.enabled;
            characterController.enabled = false;
        }

        // Телепортируем игрока на точку возрождения
        player.transform.position = new Vector3(-1, 1, 3);
        player.transform.rotation = respawnPoint.rotation;
        

        // Сбрасываем скорость (если есть Rigidbody)
        Rigidbody rb = player.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

        // Восстанавливаем состояние CharacterController
        if (characterController != null)
        {
            characterController.enabled = wasEnabled;
        }

        Debug.Log("Игрок возвращен на стартовую точку");
    }
}
