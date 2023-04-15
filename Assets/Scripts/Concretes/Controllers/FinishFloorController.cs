using System;
using System.Collections;
using System.Collections.Generic;
using Cleancode_App.Controllers;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishFloorController : MonoBehaviour
{
    [SerializeField] private GameObject[] fireworks;
    
    private void OnCollisionEnter(Collision collision)
    {
        PlayerController player = collision.collider.GetComponent<PlayerController>();
        
        if (player == null || !player.CanMove) return;

        if (collision.GetContact(0).normal.y == -1)
        {
            foreach (var firework in fireworks)
            {
                firework.SetActive(true);
            }
            GameManager.Instance.MissionSucceed();
        }
        else
        {
            GameManager.Instance.GameOver();
        }
    }
}
