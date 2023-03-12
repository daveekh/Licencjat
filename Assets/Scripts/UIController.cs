using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour {

    public TMP_Text gameStateValue;
    public GameManager gm;

    void Update() {
        gameStateValue.text = gm.gameState.ToString();
    }
}
