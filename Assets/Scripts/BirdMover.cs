using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMover : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;


    public void Move(GameObject button)
    {
        rb.velocity = Vector3.right * speed;
        button.SetActive(false);
    }

    public void Stop()
    {
        rb.velocity = Vector3.zero;
    }
}
