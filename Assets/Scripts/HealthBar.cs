using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Player _owner;
    [SerializeField] private float _changingSpeed;

    private void Start()
    {
        _slider.maxValue = _owner.CurrentHealth;
        _slider.value = _owner.CurrentHealth;
    }

    public void UpdateHealth()
    {
        StartCoroutine(ChangeValue());
    }

    private IEnumerator ChangeValue()
    {
        while (_owner.CurrentHealth != _slider.value)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _owner.CurrentHealth, _changingSpeed * Time.deltaTime);
            yield return null;
        }
    }
}
