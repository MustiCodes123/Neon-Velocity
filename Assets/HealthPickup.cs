using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int healthAmount = 10; // Amount of health to increase when picked up
    public HealthBarScript healthBar; // Reference to the health bar script assigned in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (healthBar != null)
            {
                // Increase player's health using the assigned health bar script
                healthBar.IncreaseHealth(healthAmount);

                // Destroy the health pickup GameObject
                Destroy(gameObject);
            }
            else
            {
                Debug.LogWarning("Health bar reference is not assigned! Make sure to assign the HealthBarScript in the Inspector.");
            }
        }
    }
}
