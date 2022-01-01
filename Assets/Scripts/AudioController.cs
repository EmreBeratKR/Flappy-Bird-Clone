using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] private AudioSource passSound;
    [SerializeField] private AudioSource jumpSound;
    [SerializeField] private AudioSource gameoverSound;


    public void Play_Pass()
    {
        passSound.Play();
    }

    public void Play_Jump()
    {
        if (!jumpSound.isPlaying)
        {
            jumpSound.Play();
        }
    }

    public void Play_GameOver()
    {
        gameoverSound.Play();
    }
}
