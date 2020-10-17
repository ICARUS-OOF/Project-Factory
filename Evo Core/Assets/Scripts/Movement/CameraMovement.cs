using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ProjectFactory.Movement
{
    public class CameraMovement : MonoBehaviour
    {
        Rigidbody rb;
        Quaternion deltaRotation;

        public float mouseSensitivity = 70f;

        float mouseX;
        float mouseY;
        private void Start()
        {
            rb = GetComponent<Rigidbody>();
        }
        private void Update()
        {
            GetInputs();
        }
        private void FixedUpdate()
        {
            deltaRotation = Quaternion.Euler(Vector3.up * mouseX * mouseSensitivity *  Time.fixedDeltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }
        void GetInputs()
        {
            mouseX = Input.GetAxis("Mouse X");
            mouseY = Input.GetAxis("Mouse Y");
        }
    }
}