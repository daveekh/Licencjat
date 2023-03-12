using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://www.youtube.com/watch?v=AiZ4z4qKy44

public class PlayerMovement : MonoBehaviour {

    private bool isMoving;
    private Vector3 origPos, targetPos;
    private float timeToMove = 0.2f;

    [SerializeField]
    private PlayerController pc;

    void Update() {
        
        if(Input.GetKey(KeyCode.W) && !isMoving && pc.getCanPerformAction()) 
            StartCoroutine(MovePlayer(Vector3.up));

        if(Input.GetKey(KeyCode.A) && !isMoving && pc.getCanPerformAction()) 
            StartCoroutine(MovePlayer(Vector3.left));

        if(Input.GetKey(KeyCode.S) && !isMoving & pc.getCanPerformAction()) 
            StartCoroutine(MovePlayer(Vector3.down));

        if(Input.GetKey(KeyCode.D) && !isMoving & pc.getCanPerformAction()) 
            StartCoroutine(MovePlayer(Vector3.right));

    }

    private IEnumerator MovePlayer(Vector3 dir) {

        isMoving = true;

        float elapsedTime = 0;

        origPos = transform.position;
        targetPos = origPos + dir;

        while(elapsedTime < timeToMove) {
            transform.position = Vector3.Lerp(origPos, targetPos, (elapsedTime/timeToMove));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPos;

        isMoving = false;
        pc.setCanPerformAction(false);
    }
}
