using UnityEngine;

public class SmokeRoomTrigger : MonoBehaviour
{
    public ParticleSystem smoke; // Reference to the smoke particle system

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("Trigger entered by: " + other.name); // Log the name of the object that entered the trigger

        // Check if the player enters the trigger zone
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the smoke room trigger"); // Log that the player entered the trigger
            if (!smoke.isPlaying)
            {
                // Start the smoke effect
                smoke.Play();
            }
        }
    }
    
}
