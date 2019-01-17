using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementimple : MonoBehaviour
{
    public float movementSpeed;
    // Keyboard assignment from gam designer
    public KeyCode forwardKey;
    public KeyCode backwardKey;
    public KeyCode rightwardKey;
    public KeyCode leftwardKey;
    public bool forwardKeyPress;
    public bool leftwardKeyPress;
    public bool rightwardKeyPress;
    public bool backwardKeyPress;

    // Use this for initialization
    void Start()
    {

    }
    void FixedUpdate()
    {
        if (Input.GetKey(forwardKey)) { forwardKeyPress = true; }
        else { forwardKeyPress = false; }
        if (Input.GetKey(leftwardKey)) { leftwardKeyPress = true; }
        else { leftwardKeyPress = false; }
        if (Input.GetKey(rightwardKey)) { rightwardKeyPress = true; }
        else { rightwardKeyPress = false; }
        if (Input.GetKey(backwardKey)) { backwardKeyPress = true; }
        else { backwardKeyPress = false; }

        // moving 2d with assigned keyboard
        if (Input.GetKey(KeyCode.LeftShift) && forwardKeyPress == true) {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed * 2.5f;
        } else if (forwardKeyPress == true && !Input.GetKey(KeyCode.LeftShift)){
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
        } else if (backwardKeyPress == true) {
            transform.position -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
        }

        if (leftwardKeyPress == true && rightwardKeyPress == false) {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
        } else if (rightwardKeyPress == true && leftwardKeyPress == false) {
            transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
        }
    }
    
}
