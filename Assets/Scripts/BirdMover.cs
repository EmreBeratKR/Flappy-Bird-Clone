using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMover : MonoBehaviour
{
    [SerializeField] private AudioController audioController;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    public bool isStarted;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            jump();
        }
    }

    public void Move()
    {
        isStarted = true;
        rb.useGravity = true;
        rb.velocity = Vector3.right * speed;
    }

    public void Stop()
    {
        isStarted = false;
        rb.velocity = Vector3.zero;
        rb.constraints &= ~RigidbodyConstraints.FreezeRotationX;
        rb.AddTorque(Vector3.right * 500f);
    }

    private void jump()
    {
        if (isStarted)
        {    
            rb.velocity = Vector3.right * speed;
            rb.AddForce(Vector3.up * jumpForce);
            audioController.Play_Jump();
        }
    }
}
