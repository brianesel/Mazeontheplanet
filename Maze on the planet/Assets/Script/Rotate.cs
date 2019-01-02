using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    public float rotationAngleSpeed;
    public KeyCode rotRight;
    public KeyCode rotLeft;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Rotate x axis left and right ( horizontal)
        if (Input.GetKey(rotLeft))
        {
            transform.Rotate(Vector3.up, -rotationAngleSpeed * Time.deltaTime);
        }
        if (Input.GetKey(rotRight))
        {
            transform.Rotate(Vector3.up, rotationAngleSpeed * Time.deltaTime);
        }
    }
}
