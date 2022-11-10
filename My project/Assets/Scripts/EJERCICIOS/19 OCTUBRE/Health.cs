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

    public Image healthBar;

    public void UpdateHealthBar()
    {
        healthBar.fillAmount = Mathf.InverseLerp(0, MaxHealth, currentHealth);
    }

    private void Start()
    {
        InitialPosition = transform.position;
        currentHealth = MaxHealth;
        UpdateHealthBar();
    }

    public void TakeDmg(int damageTaken)
    {
        currentHealth -= damageTaken;

        if (currentHealth <= 0)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Die();
        }
        else
        {
            Debug.Log("Te han hecho daño, salud restante " + currentHealth);
        }
        UpdateHealthBar();
    }

    private void Update()
    {
        if (currentHealth <= 2)
        {
            healthBar.color = Color.red;
        }
        else
        {
            healthBar.color = Color.green;
        }
    }

    public virtual void Die()
    {
    }
}