using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth Instance;

    public int currentHealth;
    [SerializeField] private TMP_Text healthText;
    AudioSource audioSource;
    [SerializeField] private AudioClip damaged;

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
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayerTakeDamage(int amount)
    {
        currentHealth -= amount;
        Debug.Log("Player took damage! Health is now: " + currentHealth);
        healthText.text = "Health: " + currentHealth;
        audioSource.PlayOneShot(damaged, 1F);

        if (currentHealth <= 0)
        {
            // Handle player death
            Debug.Log("Player died!");
            SceneManager.LoadScene("LoseScene");
        }
    }
}
