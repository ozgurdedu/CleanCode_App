
using System;
using Cleancode_App.Movements;
using UnityEngine;
using UnityEngine.UI;

namespace Cleancode_App.Controllers
{
    public class FuelSlider : MonoBehaviour
    {
        private Slider slider;
        private Fuel fuel;

        private void Awake()
        {
            slider = GetComponent<Slider>();
            fuel = FindObjectOfType<Fuel>();
        }

        private void Update()
        {
            slider.value = fuel.CurrentFuel;
        }
    }
}
