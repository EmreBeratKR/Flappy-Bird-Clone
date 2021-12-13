using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgController : MonoBehaviour
{
    [SerializeField] private Transform bird;
    private float deltaX;
    private Transform current;
    private Transform next;


    private void Start()
    {
        current = transform.GetChild(0);
        next = transform.GetChild(1);
        deltaX = next.position.x - current.position.x;
    }

    private void FixedUpdate()
    {
        if (bird.position.x >= next.position.x)
        {
            current.position += Vector3.right * deltaX;
            Transform temp = current;
            current = next;
            next = temp;
        }
    }
}
