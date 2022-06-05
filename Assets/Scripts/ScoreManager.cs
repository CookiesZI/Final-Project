using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int scoreToReach;

    private int player1score = 0;
    private int player2score = 0;

    public Text Player1Score;
    public Text Player2Score;

    public void Player1Goal()
    {
        player1score++;
        Player1Score.text = player1score.ToString();
        CheckScore();
    }

    public void Player2Goal()
    {
        player2score++;
        Player2Score.text = player2score.ToString();
        CheckScore();
    }

    private void CheckScore()
    {
        if(player1score == scoreToReach || player2score == scoreToReach)
        {
            SceneManager.LoadScene(2);
        }
    }
}
