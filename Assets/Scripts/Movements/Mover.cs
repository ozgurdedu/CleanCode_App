using System.Collections;
using System.Collections.Generic;
using Cleancode_App.Controllers;
using UnityEngine;

namespace Cleancode_App.Movements
{
    public class Mover
    {
        Rigidbody _rigidbody;
        private PlayerController _playerController;
        public Mover(PlayerController playerController)
        {
            _playerController = playerController;
            _rigidbody = playerController.GetComponent<Rigidbody>();
        }

        public void FixedTick()
        {
            _rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * _playerController.Force);
        }
    }
}
