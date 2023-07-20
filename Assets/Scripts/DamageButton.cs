using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageButton : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private int _healthAmount;

    public void Damage()
    {
        _player.TakeDamage(_healthAmount);
    }
}
