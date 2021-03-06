using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            if(!isPlayer1Goal)
            {
                Debug.Log("Player 1 is Scored");
                GameObject.Find("GameManager").GetComponent<GameManager>().player1Scored();
            }
            else
            {
                Debug.Log("Player 2 is Scored");
                GameObject.Find("GameManager").GetComponent<GameManager>().player2Scored();
            }
        }    
    }
}
