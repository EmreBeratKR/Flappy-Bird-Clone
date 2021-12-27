using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgController : MonoBehaviour
{
    [SerializeField] private Transform bird;
    private float deltaX;


    private void Start()
    {
        deltaX = transform.GetChild(1).position.x - transform.GetChild(0).position.x;
    }

    private void FixedUpdate()
    {
        if (bird.position.x >= transform.GetChild(1).position.x)
        {
            transform.position += Vector3.right * deltaX;
        }
    }
}
