using UnityEngine;

public class EnemyVisibility : MonoBehaviour
{
    public Transform player;
    public float orientationScore = 0f;
    public float maxVisibilityDistance = 10f; // Max distance where visibility is possible
    public float minVisibilityDistance = 2f; // Min distance where visibility is fully visible

    private float visibilityScore = 0f;

    void Update()
    {
        Vector3 toPlayer = (player.position - transform.position);
        float distance = toPlayer.magnitude;

        // Check line of sight
        Ray ray = new Ray(transform.position, toPlayer);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.transform == player && distance <= maxVisibilityDistance)
            {
                Vector3 toPlayerNormalized = toPlayer.normalized;
                Vector3 forward = transform.forward;

                // Orientation factor
                orientationScore = Vector3.Dot(forward, toPlayerNormalized);

                // Distance factor
                float distanceFactor;
                if (distance <= minVisibilityDistance)
                {
                    // Fully visible if within min distance
                    distanceFactor = 1f;
                }
                else
                {
                    // Linearly interpolate visibility between min and max distance
                    distanceFactor = 1f - Mathf.Clamp01((distance - minVisibilityDistance) / (maxVisibilityDistance - minVisibilityDistance));
                }

                // Combine the two for a visibility score
                visibilityScore = Mathf.Clamp01(orientationScore * distanceFactor);
            }
            else
            {
                visibilityScore = 0f;
            }
        }
    }

    public float GetVisibilityScore()
    {
        return visibilityScore;
    }
}
