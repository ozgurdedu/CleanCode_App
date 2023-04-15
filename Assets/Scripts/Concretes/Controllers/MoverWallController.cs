

using System;
using Cleancode_App.Abstracts.Controllers;
using UnityEngine;


namespace Cleancode_App.Controllers
{
    public class MoverWallController : WallController
    {
        [SerializeField] private Vector3 direction;
        [SerializeField] private float factor;
        [SerializeField] private float speed = 1f;
        private Vector3 startPosition;
        private const float FULL_CIRCLE = Mathf.PI * 2f;
        
        private void Awake()
        {
            startPosition = transform.position;
        }

        private void Update()
        {
            var cycle = Time.time / speed;
            var sinWave = Mathf.Sin(cycle * FULL_CIRCLE);
            factor = Mathf.Abs(sinWave);
            
            var offset = direction * factor;
            transform.position = offset + startPosition;
            
        }
    }   
}
