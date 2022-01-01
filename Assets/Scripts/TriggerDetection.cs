using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetection : MonoBehaviour
{
    [SerializeField] private BirdMover birdMover;
    [SerializeField] private GameController gameController;


    private void OnTriggerEnter(Collider other)
    {
        if (birdMover.isStarted)
        {
            if (other.tag == "Obstacle Group")
            {
                gameController.IncreaseScore();
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (birdMover.isStarted)
        {
            if (other.gameObject.tag == "Obstacle")
            {
                birdMover.Stop();
                gameController.EndGame();
            }
        }
    }
}
