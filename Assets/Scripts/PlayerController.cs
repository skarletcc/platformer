using System;
using NUnit.Framework.Constraints;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Скорость движения
    public float Speed = 5f;
    public float JumpForce = 300f;

    private bool ifGrounded;

    void Update()
    {
        // Движение влево-вправо
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(horizontal * Speed * Time.deltaTime, 0, 0);

        // Прыжок
        if (Input.GetKeyDown(KeyCode.Space) && ifGrounded)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * JumpForce);
            ifGrounded = false;
            Debug.Log("прыгнул");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            ifGrounded = true;
        }
    }
}
