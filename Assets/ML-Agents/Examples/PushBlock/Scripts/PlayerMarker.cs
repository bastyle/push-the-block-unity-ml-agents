using UnityEngine;

public class PlayerMarker : MonoBehaviour
{
    public Transform player; // Set this to the player in the Inspector
    public Vector3 offset = new Vector3(-2, 2, 0); // Offset from the player's position
    

    void Update()
    {
        // Set the position of the marker to be above the player
        transform.position = player.position + offset;


        // Add up and down movement
        float time = Time.time;
        float verticalOffset = Mathf.Sin(time * 5f) * 0.5f; // Adjust the speed by multiplying the time value
        transform.position += new Vector3(0, verticalOffset, 0);
    }

    
}
