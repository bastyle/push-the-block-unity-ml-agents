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

        string mode = PlayerPrefs.GetString("mode", "Competition");
        Debug.Log("mode selected:: "+mode);


        switch (difficulty)
        {
                
            case "easy":
                if ("Competition".Equals(mode))
                    SceneManager.LoadScene("GitGudFinalProjectPart2Easy");
                else
                    SceneManager.LoadScene("GitGudFinalProjectPart2VsEasy");
                break;
            case "medium":
                if ("Competition".Equals(mode))
                    SceneManager.LoadScene("GitGudFinalProjectPart2Medium");
                else
                    SceneManager.LoadScene("GitGudFinalProjectPart2VsMedium");
                break;
            case "hard":
                if ("Competition".Equals(mode))
                    SceneManager.LoadScene("GitGudFinalProjectPart2Hard");
                else
                    SceneManager.LoadScene("GitGudFinalProjectPart2VsHard");
                break;
            default:
                Debug.LogError("Invalid difficulty: " + difficulty);
                break;
        }

    }
}
