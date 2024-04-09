using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents.Policies;
using Unity.Sentis;
using UnityEngine;

public class DiffSelector : MonoBehaviour
{
    void Awake()
    {
        string difficulty = PlayerPrefs.GetString("difficulty");
        Debug.Log("diffi::: " + difficulty);
    }

}
