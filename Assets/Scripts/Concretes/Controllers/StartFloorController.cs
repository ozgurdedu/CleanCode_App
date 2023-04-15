using System.Collections;
using System.Collections.Generic;
using Cleancode_App.Controllers;
using UnityEngine;

namespace Cleancode_App.Controllers
{
    public class StartFloorController : MonoBehaviour
    {
        private void OnCollisionExit(Collision collision)
        {
            PlayerController player = collision.collider.GetComponent<PlayerController>();
            if (player != null)
                Destroy(gameObject);
        }
    }
}
