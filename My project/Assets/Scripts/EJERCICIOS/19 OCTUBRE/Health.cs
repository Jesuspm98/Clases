using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int MaxHealth;
    private int currentHealth;

    private Vector3 InitialPosition;

    public Text healthText;

    private void Start()
    {
        InitialPosition = transform.position;
        currentHealth = MaxHealth;

        if (healthText != null)
        {
            healthText.text = currentHealth.ToString();
        }
    }

    public void TakeDmg(int damageTaken)
    {
        currentHealth -= damageTaken;

        if (healthText != null)
        {
            healthText.text = currentHealth.ToString();
        }

        if (currentHealth <= 0)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Die();
        }
    }

    public virtual void Die()
    {
    }
}