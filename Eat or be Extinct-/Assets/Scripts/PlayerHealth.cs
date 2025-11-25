using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int health;

    void Start()
    {
        health = maxHealth; // start full health
    }

    public void TakeDamage(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            health = 0;
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Player Died!");
        Destroy(gameObject); // player is destroyed after taking maxHealth hits
    }
}
