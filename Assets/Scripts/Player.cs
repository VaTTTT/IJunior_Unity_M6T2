using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public float CurrentHealth => _currentHealth;

    [SerializeField] private UnityEvent _healthChanged = new UnityEvent();
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _currentHealth;
    
    public event UnityAction HealthChanged
    { 
        add => _healthChanged.AddListener(value);
        remove => _healthChanged.RemoveListener(value);
    }

    public void TakeDamage(int health)
    {
        _currentHealth = Mathf.Clamp(_currentHealth - health, 0, _maxHealth);
        _healthChanged.Invoke();
    }

    public void ReceiveHeal(int health)
    {
        _currentHealth = Mathf.Clamp(_currentHealth + health, 0, _maxHealth);
        _healthChanged.Invoke();
    }
}
