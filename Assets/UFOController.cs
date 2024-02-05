using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOController : MonoBehaviour
{
    //These are built-in Unity functions

    //Start is called before the first frame update
    void Start() //represents the beginning of the game's life cycle
    {
        print("Hello World!");
        // Debug.log("Hello World!"); is the same as print
    }

    //Update is called once per frame
    void Update()
    {
        // Move Up
        if (Input.GetKey(KeyCode.UpArrow)) { // if the up arrow key is pressed
            transform.position += new Vector3(0, 0.2f, 0); // move the object up
            // print("Up Arrow Pressed");
        }

        // Move Down
        if (Input.GetKey(KeyCode.DownArrow)) { // if the down arrow key is pressed
            transform.position += new Vector3(0, -0.2f, 0); // move the object down
        }

        // Move Left
        if (Input.GetKey(KeyCode.LeftArrow)) { // if the left arrow key is pressed
            transform.position += new Vector3(-0.2f, 0, 0); // move the object left
        }

        // Move Right
        if (Input.GetKey(KeyCode.RightArrow)) { // if the right arrow key is pressed
            transform.position += new Vector3(0.2f, 0, 0); // move the object right
        }

        print("Frame"); // a frame is a unit of time that has past in the game
    }

    int Add(int a, int b) {
        return a + b;
    }
}