using UnityEngine;

public class JohnLemonHittingObjects : MonoBehaviour
{
    [SerializeField] private AudioSource gruntAudioSource;

    //noticed John would grunt when he went into rooms that had game object FLOOR
    private readonly string[] ignoredFloorNames = {
        "FloorPlane",
        "Floor_Bathroom",
        "Floor_DiningRoom",
        "Floor_Bedroom"
    };

    void OnCollisionEnter(Collision collision)
    {
        string hitName = collision.gameObject.name;

        foreach (string ignoredName in ignoredFloorNames)
        {
            if (hitName == ignoredName)
                return;
        }

        if (!gruntAudioSource.isPlaying)
        {
            gruntAudioSource.Play();
        }
    }
}
