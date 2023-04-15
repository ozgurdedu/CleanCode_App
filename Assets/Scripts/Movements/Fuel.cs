using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cleancode_App.Movements
{
    public class Fuel : MonoBehaviour
    {
        [SerializeField] private float _maxFuel = 100f;
        [SerializeField] private float _currentFuel;
        [SerializeField] private ParticleSystem _particle;

        public bool IsEmpty => _currentFuel < 1;
        public float CurrentFuel => _currentFuel / _maxFuel;
        
            
        private void Awake()
        {
            _currentFuel = _maxFuel; 
        }

        public void FuelIncrease(float increase)
        {
            _currentFuel += increase;
            _currentFuel = Mathf.Min(_currentFuel, _maxFuel);
      
            if (_particle.isPlaying)
            {
                _particle.gameObject.SetActive(false);
                _particle.Stop();
            }
        }

        public void FuelDecrease(float increase)
        {
            _currentFuel -= increase;
            _currentFuel = Mathf.Max(_currentFuel, 0 );

            if (_particle.isStopped)
            {  
                _particle.gameObject.SetActive(true);
                _particle.Play();
            }


        }
    }
}

