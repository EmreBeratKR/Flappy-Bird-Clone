using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameController gameController;
    [SerializeField] private TextMeshProUGUI score;
    [SerializeField] private TextMeshProUGUI highestScore;
    [SerializeField] private GameObject startButton;
    [SerializeField] private GameObject restartButton;
    [SerializeField] private BirdMover birdMover;


    private void Start()
    {
        Update_HighestScore();
    }

    public void Start_Game()
    {
        startButton.SetActive(false);
        highestScore.gameObject.SetActive(false);
        birdMover.Move();
    }

    public void Restart_Game()
    {
        SceneManager.LoadScene(0);
    }

    public void Open_EndScreen()
    {
        restartButton.SetActive(true);
    }

    public void Update_Score()
    {
        score.text = gameController.score.ToString();
    }

    public void Update_HighestScore()
    {
        highestScore.text = "Highest Score: " + PlayerPrefs.GetInt("Highest Score", 0).ToString();
    }
}
