using System;
using System.Collections;
using System.Collections.Generic;
using Cleancode_App.Inputs;
using Cleancode_App.Movements;
using UnityEngine;
using UnityEngine.Serialization;


namespace Cleancode_App.Controllers
{
    
    public class PlayerController : MonoBehaviour
    {
        

        [SerializeField]  float turnSpeed = 20f; 
        [SerializeField]  float force = 150f;
        
         DefaultInput input;
         Mover mover;
         Fuel fuel; 
         Rotator rotator;
         bool canMove;
         bool canForceUp;
         float leftRight;
        
         
         public float TurnSpeed => turnSpeed;
         public float Force => force;
         public bool CanMove => canMove;

       
         
         private void Awake()
        {
            input = new DefaultInput();
            mover = new Mover(this);
            rotator = new Rotator(this);
            fuel = GetComponent<Fuel>();
        }
         private void Start()
         {
             canMove = true;
         }
         
         private void OnEnable()
         {
             GameManager.Instance.OnGameOver += OnMotionless;
             GameManager.Instance.OnMissionSucceed += OnMotionless;
         }

         private void OnDisable()
         {
             GameManager.Instance.OnGameOver -= OnMotionless;
             GameManager.Instance.OnMissionSucceed -= OnMotionless;
         }

    
       

        private void Update()
        {

            if (!canMove) return;
          
            //input
            if (input.IsForcedUp && !fuel.IsEmpty)
                canForceUp = true;
            else
            {
                canForceUp = false;
                fuel.FuelIncrease(0.01f);
            }

            leftRight = input.LeftRight;
        }

        private void FixedUpdate()
        {
            //physics 
            if (canForceUp)
            {
                mover.FixedTick();
                fuel.FuelDecrease(0.2f);
            }
            
            rotator.FixedTick(leftRight);
        
        }
        
        private void OnMotionless()
        {
            canMove = false;
            canForceUp = false;
            leftRight = 0.0f;
            fuel.FuelIncrease(0.0f);
        }
    }
}

