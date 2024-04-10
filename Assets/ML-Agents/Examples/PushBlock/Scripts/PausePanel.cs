using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePanel : MonoBehaviour
{
    public GameObject pausePanel; // Add this field

    void Start()
    {
        //Debug.Log("Pause:::::::::::::::::::::::::::::::::");
        //pausePanel = GameObject.FindGameObjectWithTag("pausePanel");
    }

    void Update()
    {
        // Check if the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape)  && !pausePanel.activeSelf)
        {
            pausePanel.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && pausePanel.activeSelf)
        {
            pausePanel.SetActive(false);
        }
    }

    public void ResetLevel()
    {
        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoHome()
    {
        // Load the home scene
        SceneManager.LoadScene("Start"); // Replace with the name of your home scene
    }

    public void Cancel()
    {
        // Load the home scene
        //SceneManager.LoadScene("Cancel"); // Replace with the name of your home scene
        pausePanel.SetActive(false);
    }


}
