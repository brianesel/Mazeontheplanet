using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    public float rotationAngleSpeed;
    public KeyCode rotRight;
    public KeyCode rotLeft;
    public bool rotrightbuttonpress;
    public bool rotleftbuttonpress;
    // Use this for initialization
    void Start () {
        rotrightbuttonpress = false;
        rotleftbuttonpress = false;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey(rotLeft)) { rotleftbuttonpress = true; }
        if (Input.GetKey(rotRight)) { rotrightbuttonpress = true; }

        // Rotate x axis left and right ( horizontal)
        if (rotleftbuttonpress == true)
        {
            transform.Rotate(Vector3.up, -rotationAngleSpeed * Time.deltaTime);
        }
        else { }

        if (rotrightbuttonpress == true)
        {
            transform.Rotate(Vector3.up, rotationAngleSpeed * Time.deltaTime);

        }
        else { }
    }
}
