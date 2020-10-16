using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ProjectFactory.Movement
{
    public class CameraMovement : MonoBehaviour
    {
        public Transform player;
        public float offsetY = 0.75f;
        void Update()
        {
            transform.position = player.transform.position + new Vector3(0f, offsetY, 0f);
        }
    }
}