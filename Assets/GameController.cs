using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter {
    public class GameController : MonoBehaviour {

        public static GameController instance;

        // State Tracking
        public float timeElapsed;

        // Methods
        void Awake () {
            instance = this;
        }

        void Update(){
            // Increment passafe of time for each frame of the game
            timeElapsed += Time.deltaTime;
        }
    }
}
