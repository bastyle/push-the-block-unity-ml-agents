using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents.Policies;
using Unity.Sentis;
using UnityEngine;
using UnityEngine.UI;
public class StartLevel : MonoBehaviour
{

    public const int DefaultGoals = 1;

    void Awake()
    {
        /*string difficulty = PlayerPrefs.GetString("difficulty");
        //int goals = PlayerPrefs.GetInt("goals");
        int goals = PlayerPrefs.GetInt("goals", DefaultGoals); // Use the default value if no value is found
        Debug.Log("diffi::: " + difficulty+ "goals::"+goals);
        //m_BehaviorParameters = gameObject.GetComponent<BehaviorParameters>();
        ScoreManager.instance.maxScore = goals;
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
        }*/
    }

}
