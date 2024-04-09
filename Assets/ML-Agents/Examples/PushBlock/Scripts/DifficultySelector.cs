// DifficultySelector.cs
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultySelector : MonoBehaviour
{
    public void OnButtonClick(string difficulty)
    {
        Debug.Log("Button clicked! "+ difficulty);
        SceneManager.LoadScene("GitGudFinalProjectPart2");
    }
}
