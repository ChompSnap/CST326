using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    private int player1Score;
    private int player2Score;
    public Text player1Text;
    public Text player2Text;


    public void Player1Point()
    {
        player1Score++;
        this.player1Text.text = player1Score.ToString();
        if (player1Score == 11)
        {
            Debug.Log("GAME OVER!!! Player 1 Wins!!!");
            player2Score = 0;
            this.player2Text.text = player2Score.ToString();
            player1Score = 0;
            this.player1Text.text = player1Score.ToString();
        }
        else
        {
            Debug.Log("Current Score: Player 1: " + player1Score + " | Player 2: " + player2Score);
        }
        this.ball.ResetPostion();
    }
    public void Player2Point()
    {
        player2Score++;
        this.player2Text.text = player2Score.ToString();
        if(player2Score == 11)
        {
            Debug.Log("GAME OVER!!! Player 2 Wins!!!");
            player2Score = 0;
            this.player2Text.text = player2Score.ToString();
            player1Score = 0;
            this.player1Text.text = player1Score.ToString();
        }
        else
        {
            Debug.Log("Current Score: Player 1: " + player1Score + " | Player 2: " + player2Score); 
        }
        this.ball.ResetPostion();
    }

    private void ResetBall()
    {

    }
}
