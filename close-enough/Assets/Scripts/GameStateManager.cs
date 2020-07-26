using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameStateManager : MonoBehaviour
{
    [SerializeField]
    private GameState state;
    private AudioSource AudioSource;
    [SerializeField]
    private GameObject GameOverScreen;

    void Start()
    {
        state.ResetGameState();
        state.OnGameOver.AddListener(OnGameOver);
        AudioSource = GetComponent<AudioSource>();
        AudioSource.Play();
    }

    void Update()
    {
        state.UpdateScore();
    }

    void OnGameOver()
    {
        AudioSource.Stop();
        GameOverScreen.SetActive(true);
    }
}
