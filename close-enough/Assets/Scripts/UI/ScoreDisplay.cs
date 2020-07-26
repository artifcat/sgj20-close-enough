using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField]
    private GameState gameState;
    [SerializeField]
    private TextMeshProUGUI scoreText;

    void Start()
    {
        
    }

    void Update()
    {
        scoreText.text = gameState.Score.ToString("F0") + " m";
    }
}
