using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "GameState", menuName = "close-enough/GameState", order = 0)]
public class GameState : ScriptableObject
{
    [Header("Balancing")]
    public float timeScoreMultiplier = 1f;

    public float Score { get {return score;} }
    public bool IsGameOver { get {return isGameOver;} }
    public bool IsPlaying { get {return isPlaying;} }
    public UnityEvent OnGameOver = new UnityEvent();

    private float score;
    private bool isGameOver;
    private bool isPlaying;

    // run in Update()
    public void UpdateScore()
    {
        if(!isGameOver)
        {
            score += Time.deltaTime * timeScoreMultiplier;
        }
    }

    public void SetGameOver()
    {
        isGameOver = true;
        OnGameOver.Invoke();
        isPlaying = false;
    }

    public void ResetGameState()
    {
        isGameOver = false;
        score = 0f;
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        isPlaying = true;
    }

}
