using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public Ball ball;
    private int _playerScore;
    private int _computerScore;
    public TMP_Text playerScoreText;
    public TMP_Text computerScoreText;

    public void PlayerScores()
    {
        _playerScore++;

        this.playerScoreText.text = this._playerScore.ToString();

        ResetRound();
    }

    public void ComputerScore()
    {
        _computerScore++;

        this.computerScoreText.text = this._computerScore.ToString();

        ResetRound();

    }

    public void ResetRound()
    {
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

}
