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
    }
}
