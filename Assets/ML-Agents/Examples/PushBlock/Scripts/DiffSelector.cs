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
    // Start is called before the first frame update
    void Start()
    {
       // BehaviorParameters bp = GetComponent<BehaviorParameters>();
        //bp.Model = new ModelAsset();
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
