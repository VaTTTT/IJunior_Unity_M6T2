using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _currentHealth;

    public float MaxHealth => _maxHealth;
    public float CurrentHealth => _currentHealth;

    public void TakeDamage(int health)
    {
        if (_currentHealth - health > 0)
        {
            _currentHealth -= health;
        }

        else
        {
            _currentHealth = 0;
        } 
    }

    public void ReceiveHeal(int health)
    {
        if (_currentHealth < _maxHealth - health)
        {
            _currentHealth += health;
        }

        else
        {
            _currentHealth = MaxHealth;
        }
    }
}
