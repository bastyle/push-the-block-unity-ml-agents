// ScoreManager.cs
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int agentScore = 0;
    public int playerScore = 0;

    public Text agentScoreText;
    public Text playerScoreText;
    public int maxScore = 10;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void UpdateScore(BlockType type)
    {
        Debug.Log("updating..........");
        if (type == BlockType.Agent)
        {
            agentScore++;
            agentScoreText.text = "" + agentScore;
        }
        else if (type == BlockType.Player)
        {
            playerScore++;
            playerScoreText.text = "" + playerScore;
        }
        // Check if the game is over
        if (agentScore >= maxScore || playerScore >= maxScore)
        {
            GameOverText.instance.ShowGameOver(playerScore >= maxScore);
        }
    }


}
