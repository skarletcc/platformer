using UnityEngine;

public class Bouncer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float bounceForce = 20f;
    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PlayerController>(out var player))
        {
            other.GetComponent<Rigidbody>().AddForce(Vector3.up * bounceForce);
        }
    }

    void Update()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * bounceForce);
    }
}
