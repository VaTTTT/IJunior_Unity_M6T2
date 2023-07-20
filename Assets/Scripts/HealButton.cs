using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealButton : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private int _healthAmount;

    public void Heal()
    {
        _player.ReceiveHeal(_healthAmount);
    }
}
