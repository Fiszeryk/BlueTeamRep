using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        // Handle any player-specific behavior upon taking damage

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Handle player death behavior, e.g., play death animation, end the game, etc.
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("menu");
    }
}
