using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    [SerializeField]
    private GameState gameState;

    private void OnCollisionEnter(Collision other) 
    {
        //player hit the ground, game is over
        gameState.SetGameOver();
    }
}
