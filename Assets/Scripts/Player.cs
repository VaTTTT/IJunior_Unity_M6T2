using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _currentHealth;

    public float GetHealth()
    {
        return _currentHealth;
    }

    public float GetMaxHealth()
    {
        return _maxHealth;
    }

    public void TakeDamage(int health)
    {
        if (_currentHealth > 0)
        { 
        _currentHealth -= health;
        }
    }

    public void ReceiveHeal(int health)
    {
        if (_currentHealth < _maxHealth)
        {
            _currentHealth += health;
        }
    }
}
