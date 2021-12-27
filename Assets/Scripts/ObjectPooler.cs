using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    [SerializeField] private ObstacleSpawner obstacleSpawner;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle Group")
        {
            obstacleSpawner.Pool();
        }
    }
}
