using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetection : MonoBehaviour
{
    [SerializeField] private GameController gameController;
    [SerializeField] private AudioController audioController;
    [SerializeField] private BirdMover birdMover;


    private void OnTriggerEnter(Collider other)
    {
        if (birdMover.isStarted)
        {
            if (other.tag == "Obstacle Group")
            {
                gameController.IncreaseScore();
                audioController.Play_Pass();
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
                audioController.Play_GameOver();
            }
        }
    }
}
