using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameStateManager : MonoBehaviour
{
    [SerializeField]
    private GameState state;

    void Start()
    {
        state.ResetGame();
        state.OnGameOver.AddListener(OnGameOver);
    }

    void Update()
    {
        state.UpdateScore();
    }

    void OnGameOver()
    {
        Debug.Log("The game is over, reset it here.");
    }
}
