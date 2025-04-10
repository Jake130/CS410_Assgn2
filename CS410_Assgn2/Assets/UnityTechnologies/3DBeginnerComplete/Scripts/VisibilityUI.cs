using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisibilityUI : MonoBehaviour
{
    public Image visibilityFillImage; // Reference to the filled image
    public List<EnemyVisibility> enemies;

    void Start()
    {
        if (enemies == null || enemies.Count == 0)
        {
            // Use FindObjectsByType with FindObjectsSortMode.None for better performance
            enemies = new List<EnemyVisibility>(FindObjectsByType<EnemyVisibility>(FindObjectsSortMode.None));
        }
    }

    void Update()
    {
        float maxVisibility = 0f;

        foreach (EnemyVisibility enemy in enemies)
        {
            if (enemy != null)
            {
                float score = enemy.GetVisibilityScore();
                score = Mathf.Clamp01(score);
                if (score > maxVisibility)
                    maxVisibility = score;
            }
        }

        // Smooth fill transition
        visibilityFillImage.fillAmount = Mathf.Lerp(visibilityFillImage.fillAmount, maxVisibility, Time.deltaTime * 5f);
    }
}