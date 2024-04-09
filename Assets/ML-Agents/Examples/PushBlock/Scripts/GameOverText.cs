// GameOverText.cs
using UnityEngine;
using UnityEngine.UI;

public class GameOverText : MonoBehaviour
{
    public static GameOverText instance;

    private Text text;

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

        text = GetComponent<Text>();

        // Disable the text by default
        gameObject.SetActive(false);
    }

    public void ShowGameOver(bool playerWon)
    {
        // Update the text and enable it
        text.text = playerWon ? "You Win!" : "You Lose!";
        gameObject.SetActive(true);
    }
}
