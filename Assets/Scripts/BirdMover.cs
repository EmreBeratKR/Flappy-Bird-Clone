using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMover : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }
    }

    public void Move(GameObject button)
    {
        rb.useGravity = true;
        rb.velocity = Vector3.right * speed;
        button.SetActive(false);
    }

    public void Stop()
    {
        rb.velocity = Vector3.zero;
    }

    private void jump()
    {
        rb.velocity = Vector3.right * speed;
        rb.AddForce(Vector3.up * jumpForce);
    }
}
