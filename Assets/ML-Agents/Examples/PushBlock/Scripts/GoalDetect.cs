//Detect when the orange block has touched the goal.
//Detect when the orange block has touched an obstacle.
//Put this script onto the orange block. There's nothing you need to set in the editor.
//Make sure the goal is tagged with "goal" in the editor.

using UnityEngine;

public enum BlockType
{
    Player=1,
    Agent=0
}
public class GoalDetect : MonoBehaviour
{
    /// <summary>
    /// The associated agent.
    /// This will be set by the agent script on Initialization.
    /// Don't need to manually set.
    /// </summary>
    [HideInInspector]
    public PushAgentBasic agent;  //
    public BlockType type;

    void OnCollisionEnter(Collision col)
    {
        // Touched goal.
        if (col.gameObject.CompareTag("goal"))
        {
            switch (type)
            {
                case BlockType.Agent:
                    //Debug.Log("Goal!!!!!!!!!!!! Agent");
                    break;
                case BlockType.Player:
                    //Debug.Log("Goal!!!!!!!!!!!! Player");
                    break;
                
            }
            agent.ScoredAGoal();
            ScoreManager.instance.UpdateScore(type);
        }
    }
}
