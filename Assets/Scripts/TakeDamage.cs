// In the PlayerHealth script

using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBarScript healthBar; // Reference to the health bar script
    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamageForPlayer(int damage)
    {
        if (!healthBar.isInvincible)
        {
            if (currentHealth >= 0)
            currentHealth -= damage;

            healthBar.SetHealth(currentHealth);
        }
        else {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
