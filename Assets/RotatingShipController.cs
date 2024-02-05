using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Q2 {
    public class RotatingShipController : MonoBehaviour
    {
        // Outlets
        Rigidbody2D _rb;

        // Configuration
        public float speed;
        public float rotationSpeed;

        // State Tracking

        // Methods
        void Start() {
            _rb = GetComponent<Rigidbody2D>();
        }

        void Update() { //repeats faster
            //Turn Left
            if(Input.GetKey(KeyCode.LeftArrow)) {
                _rb.AddTorque(rotationSpeed * Time.deltaTime);
            }

            //Turn Right
            if(Input.GetKey(KeyCode.RightArrow)) {
                _rb.AddTorque(-rotationSpeed * Time.deltaTime);
            }

            //Thrust forward
            if(Input.GetKey(KeyCode.Space)) {
                _rb.AddRelativeForce(Vector2.right * speed * Time.deltaTime); //relative right
                //_rb.AddForce(Transform.right * speed * Time.deltaTime) //universial right
            }
        }
    }
}
