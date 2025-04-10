using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth Instance;

    public int currentHealth = 10;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void PlayerTakeDamage(int amount)
    {
        currentHealth -= amount;
        Debug.Log("Player took damage! Health is now: " + currentHealth);

        if (currentHealth <= 0)
        {
            // Handle player death
            Debug.Log("Player died!");
        }
    }
}
