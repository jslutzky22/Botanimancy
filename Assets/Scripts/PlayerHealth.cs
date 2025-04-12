using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth Instance;

    public int currentHealth;
    [SerializeField] private TMP_Text healthText;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        if (currentHealth == 0)
        {
            currentHealth = 10;
        }
        healthText.text = "Health: " + currentHealth;
    }

    public void PlayerTakeDamage(int amount)
    {
        currentHealth -= amount - 1;
        Debug.Log("Player took damage! Health is now: " + currentHealth);
        healthText.text = "Health: " + currentHealth;

        if (currentHealth <= 0)
        {
            // Handle player death
            Debug.Log("Player died!");
            SceneManager.LoadScene("LoseScene");
        }
    }
}
