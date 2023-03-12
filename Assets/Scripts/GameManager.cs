using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState {
    Start,
    PlayerTurn,
    EnemyTurn,
    Victory,
    Lose
}

public class GameManager : MonoBehaviour {
    
    public static GameManager Instance;

    public GameState gameState;
    public PlayerController pc;


    public void setGameState(GameState newState) {
        gameState = newState;

        switch(newState) {

            case GameState.Start:
                break;
            case GameState.PlayerTurn:
                pc.setCanPerformAction(true);
                break;
            case GameState.EnemyTurn:
                break;
            case GameState.Victory:
                break;
            case GameState.Lose:
                break;
            default:
                break;
        }
    }

    public void StartButton() {
        setGameState(GameState.PlayerTurn);

    }

    public void SkipEnemyTurnButton() {
        setGameState(GameState.PlayerTurn);
    }

    public void QuitButton() {
        Application.Quit();
    }

    public void Awake() {
        Instance = this;
    }

    public void Start() {
        setGameState(GameState.Start);
    }
    


}
