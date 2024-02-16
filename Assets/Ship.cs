using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    //Method
    // Update is called once per frame
    void Update()
    {
        float yPosition = Mathf.Sin(GameController.instance.timeElapsed) * 3f;
        transform.position = new Vector2(0, yPosition);
    }
}
