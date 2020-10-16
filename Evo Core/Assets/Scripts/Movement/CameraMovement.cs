using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ProjectFactory.Movement
{
    public class CameraMovement : MonoBehaviour
    {
        public Transform player;
        void Update()
        {
            transform.position = player.transform.position;
        }
    }
}