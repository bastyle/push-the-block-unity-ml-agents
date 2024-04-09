// DifficultySelector.cs

using Unity.MLAgents.Policies;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultySelector : MonoBehaviour
{
    public void OnButtonClick(string difficulty)
    {
        Debug.Log("Button clicked! "+ difficulty);
        PlayerPrefs.SetString("difficulty", difficulty);
        // create 3 different scenes
        SceneManager.LoadScene("GitGudFinalProjectPart2");
        
    }
}
