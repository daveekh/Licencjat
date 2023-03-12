using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private bool canPerformAction = false;
    public GameManager gm;

    public bool getCanPerformAction() {
        return canPerformAction;
    }

    public void setCanPerformAction(bool value) {
        canPerformAction = value;
    }

    void Update() {
        if(gm.gameState == GameState.PlayerTurn && canPerformAction == false) {
            gm.setGameState(GameState.EnemyTurn);
        }
    }
}
