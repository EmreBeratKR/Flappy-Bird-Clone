using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private SceneController sceneController;
    public int score = 0;


    public void IncreaseScore()
    {
        score++;
        sceneController.Update_Score();
    }

    public void EndGame()
    {
        SaveHighestScore();
        sceneController.Open_EndScreen();
    }

    public void SaveHighestScore()
    {
        if (PlayerPrefs.GetInt("Highest Score", 0) < score)
        {
            PlayerPrefs.SetInt("Highest Score", score);
        }
    }
}
