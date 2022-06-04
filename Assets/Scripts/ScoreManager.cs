using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int player1score = 0;
    private int player2score = 0;

    public Text Player1Score;
    public Text Player2Score;

    public void Player1Goal()
    {
        player1score++;
        Player1Score.text = player1score.ToString();
    }

    public void Player2Goal()
    {
        player2score++;
        Player2Score.text = player2score.ToString();
    }
}
