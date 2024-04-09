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
    public const int DefaultGoals = 1;
    private int maxScore = DefaultGoals;

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
        string difficulty = PlayerPrefs.GetString("difficulty");
        int goals = PlayerPrefs.GetInt("goals", DefaultGoals); 
        Debug.Log("diffi::: " + difficulty + "goals::" + goals);
        maxScore = goals;
        GameObject textObject = GameObject.FindGameObjectWithTag("FT");
        if (textObject != null)
        {
            Debug.Log("textObject != null!!");
            // Get the Text component and set its value
            Text text = textObject.GetComponent<Text>();
            if (text != null)
            {
                Debug.Log("changing FT value!!");
                text.text = "FT" + goals;
            }
            else
            {
                Debug.LogError("No Text component found on GameObject with tag 'FT'");
            }
        }
        else
        {
            Debug.LogError("No GameObject found with tag 'FT'");
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
