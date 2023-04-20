using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LogicScript : MonoBehaviour
{
    private int playerScore = 0, computerScore = 0;
    public TMP_Text playerScoreText, computerScoreText;

    public BallScript ballScript;

    [SerializeField] PaddleScript playerPaddle;
    [SerializeField] PaddleScript computerPaddle;

    public void PlayerScores()
    {
        playerScore++;
        //print("Player score: " + playerScore);

        playerScoreText.text = "PLAYER SCORE: " + playerScore.ToString();
        ResetRound();
    }

    public void ComputerScores()
    {
        computerScore++;
        //print("Computer Score: " + computerScore);
        computerScoreText.text = "COMPUTER SCORE: " + computerScore.ToString();
        
        ResetRound();
    }

    private void ResetRound()
    {
        ballScript.ResetPosition();
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        ballScript.AddStartingForce();
    }

}
