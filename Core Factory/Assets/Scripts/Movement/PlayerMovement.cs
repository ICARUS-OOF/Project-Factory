using UnityEngine;
using System;
namespace ProjectFactory.Movement
{
    public class PlayerMovement : MonoBehaviour
    {

        //Prime booleans
        public bool canMove = true;
        //Speed
        [Range(3f, 13f)]
        private float speed = 7f;

        //Jumping and physics
        [Range(0f, 10f)]
        public float jumpHeight = 5f;
        [Range(0f, 6f)]
        public float groundDistance = 3f;
        public LayerMask groundMask;
        public bool isGrounded;

        //Inputs
        float horizontal;
        float vertical;

        //Ranges
        public float dropRange = 5f;

        //Private references
        Rigidbody rb;

        //References
        public Transform groundCheck;

        //Dimensions
        public Vector3 forward;
        Vector3 deltaPos;

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        }

        private void Update()
        {
            /*
            Transform camTransform = CameraController.singleton.transform;
            forward = camTransform.position + camTransform.forward * dropRange;
            */

            GetInputs();

            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

            if (Input.GetButtonDown("Jump") && isGrounded)
            {
                rb.velocity += (Vector3.up * jumpHeight);
            }
        }

        private void FixedUpdate()
        {
            /*
            if (PlayerUI.singleton.isNotOnWorld)
            {
                return;
            }
            */
            deltaPos = ((transform.forward * vertical) + (transform.right * horizontal)) * speed * Time.fixedDeltaTime;
            rb.MovePosition(rb.position + deltaPos);
        }

        private void GetInputs()
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
        }
        #region Singleton
        public static PlayerMovement singleton;
        private void Awake()
        {
            if (singleton == null)
            {
                singleton = this;
            }
        }
        #endregion
    }
}
