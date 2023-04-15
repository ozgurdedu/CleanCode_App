using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cleancode_App.Inputs
{
    public class DefaultInput
    {
        private DefaultAction _input;
        public bool IsForcedUp { get; private set; }
        public float LeftRight { get; private set; }

        public DefaultInput()
        {
            _input = new DefaultAction();
            // true false dönecek input -> basılı mı değil mi kontrolü
            _input.Rocket.ForceUp.performed += context => IsForcedUp = context.ReadValueAsButton();
            // +1 ve -1 dönecek input
            _input.Rocket.LeftRight.performed += context => LeftRight = context.ReadValue<float>(); 
            _input.Enable();
        }


    }

}