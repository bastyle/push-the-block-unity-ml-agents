// DifficultySelector.cs

using Unity.MLAgents.Policies;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultySelector : MonoBehaviour
{
    public void OnButtonClick(string difficulty)
    {
        Debug.Log("Button clicked! " + difficulty);
        PlayerPrefs.SetString("difficulty", difficulty);
        // create 3 different scenes
        SceneManager.LoadScene("GitGudFinalProjectPart2");

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
