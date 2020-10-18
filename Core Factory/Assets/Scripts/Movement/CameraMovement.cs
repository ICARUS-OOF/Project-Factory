using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ProjectFactory.Movement
{
    public class CameraMovement : MonoBehaviour
    {
        public float mouseSensitivity = 100f;
        public Transform cam;

        float xRotation = 0f;

        void Update()
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.fixedDeltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.fixedDeltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            cam.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

            transform.Rotate(Vector3.up * mouseX);
        }
    }
}