using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    public event Action<int> OnHealthChanged;
    public event Action OnPlayerDead;

    void Start()
{
    currentHealth = maxHealth;
}

   public void TakeDamage(int damage)
{
    currentHealth -= damage;
    currentHealth = Mathf.Max(currentHealth, 0);

    Debug.Log("TakeDamage called, HP = " + currentHealth);

    OnHealthChanged?.Invoke(currentHealth);

    if (currentHealth <= 0)
    {
        OnPlayerDead?.Invoke();
    }
}

}
