// DifficultySelector.cs

using Unity.MLAgents.Policies;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DifficultySelector : MonoBehaviour
{

    public InputField goalsInputField;
    public Text validationMessageText;
    public void OnButtonClick(string difficulty)
    {
        Debug.Log("Button clicked! " + difficulty);
        PlayerPrefs.SetString("difficulty", difficulty);
        // create 3 different scenes
        //SceneManager.LoadScene("GitGudFinalProjectPart2");
        string goals = goalsInputField.text;
        int goalsNumber;
        if (!int.TryParse(goals, out goalsNumber) || goalsNumber <= 0)
        {
            // If the input is not a positive integer, show a validation message and return
            validationMessageText.text = "Please enter a positive number of goals.";
            return;
        }
        PlayerPrefs.SetInt("goals", int.Parse(goals));

        validationMessageText.text = "";

        switch (difficulty)
        {
            case "easy":
                SceneManager.LoadScene("GitGudFinalProjectPart2Easy");
                break;
            case "medium":
               SceneManager.LoadScene("GitGudFinalProjectPart2Medium");
                break;
            case "hard":
               SceneManager.LoadScene("GitGudFinalProjectPart2Hard");
                break;
            default:
                Debug.LogError("Invalid difficulty: " + difficulty);
                break;
        }

    }
}
