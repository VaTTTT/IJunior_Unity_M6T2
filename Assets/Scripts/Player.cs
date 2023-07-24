using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public float CurrentHealth => _currentHealth;
    public UnityAction OnHealthChanged;
   
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _currentHealth;

    public void TakeDamage(int health)
    {
        _currentHealth = Mathf.Clamp(_currentHealth - health, 0, _maxHealth);
        OnHealthChanged?.Invoke();
    }

    public void ReceiveHeal(int health)
    {
        _currentHealth = Mathf.Clamp(_currentHealth + health, 0, _maxHealth);
        OnHealthChanged?.Invoke();
    }
}
