using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _changingSpeed;
    [SerializeField] private Player _owner;

    private void Start()
    {
        GetComponent<Slider>().maxValue = _owner.CurrentHealth;
        GetComponent<Slider>().value = _owner.CurrentHealth;
    }

    private void Update()
    {
        if (_owner.CurrentHealth != _slider.value)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _owner.CurrentHealth, _changingSpeed * Time.deltaTime);
        }
    }
}
