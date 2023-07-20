using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _currentHealth;
    [SerializeField] private HealthBar _healthBar;

    //public float MaxHealth => _maxHealth;
    public float CurrentHealth => _currentHealth;

    public void TakeDamage(int health)
    {
        _currentHealth = Mathf.Clamp(_currentHealth - health, 0, _maxHealth);
        StartCoroutine(_healthBar.CorrectValue());
    }

    public void ReceiveHeal(int health)
    {
        _currentHealth = Mathf.Clamp(_currentHealth + health, 0, _maxHealth);
        StartCoroutine(_healthBar.CorrectValue());
    }
}
