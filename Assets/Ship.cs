using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter {
    public class Ship : MonoBehaviour
    {
        // Outlet
        public GameObject projectilePrefab;

        // State Tracking
        public float firingDelay = 1f;

        //Methods
        
        void FireProjectile() {
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }

        IEnumerator FiringTimer() {
            yield return new WaitForSeconds(firingDelay);

            FireProjectile();

            StartCoroutine("FiringTimer");
        }

        void Start() {
            StartCoroutine("FiringTimer");
        }

        void Update()
        {
            float yPosition = Mathf.Sin(GameController.instance.timeElapsed) * 3f;
            transform.position = new Vector2(0, yPosition);
        }
    }
}