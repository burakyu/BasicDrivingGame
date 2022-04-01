using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public FloatingJoystick variableJoystick;

    // Update is called once per frame
    void Update()
    {
        //Moves the car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //Rotates the car based on horizontal input
        transform.Rotate(Vector3.up,  Time.deltaTime * turnSpeed * variableJoystick.Horizontal);
    }
}
