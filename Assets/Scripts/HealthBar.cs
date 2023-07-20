using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private float _changingSpeed;
    [SerializeField] private Player owner;

    private void Start()
    {
        GetComponent<Slider>().maxValue = owner.GetMaxHealth();
        GetComponent<Slider>().value = owner.GetHealth();
    }

    void Update()
    {
        if (owner.GetHealth() != GetComponent<Slider>().value)
        {
            GetComponent<Slider>().value = Mathf.MoveTowards(GetComponent<Slider>().value, owner.GetHealth(), _changingSpeed * Time.deltaTime);
        }
    }
}
