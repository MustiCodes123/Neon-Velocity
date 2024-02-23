// In the PlayerHealth script

using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    public HealthBarScript healthBar; // Reference to the health bar script

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamageForPlayer(int damage)
    {
        if(currentHealth>=0)
        currentHealth -= damage;
        Debug.Log(currentHealth);
        // Update the health bar UI
        healthBar.SetHealth(currentHealth);

        // Check if the player is dead
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
