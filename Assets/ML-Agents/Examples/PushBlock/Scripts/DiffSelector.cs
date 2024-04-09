using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents.Policies;
using Unity.Sentis;
using UnityEngine;

public class DiffSelector : MonoBehaviour
{

    BehaviorParameters m_BehaviorParameters;

    void Awake()
    {
        string difficulty = PlayerPrefs.GetString("difficulty");
        Debug.Log("diffi::: " + difficulty);
        m_BehaviorParameters = gameObject.GetComponent<BehaviorParameters>();
        
    }

}
