using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManipulation : MonoBehaviour
{
    private GameObject condition;
    public GameObject Player;
    public float lerpTime = 3f;
    public bool collision = false;
    private int transforming;
    private bool gravCheck;
    public KeyCode gravityKey;
    private Vector3 gravtoX = new Vector3(9.81f, 0, 0);
    private Vector3 gravtonegaY = new Vector3(0, -9.81f, 0);
    private Vector3 gravtonegaZ = new Vector3(0, 0, -9.81f);
    private float yrotdeg;
    private float xrotdeg;
    private float zrotdeg;
    // Use this for initialization
    void Start()
    {
        gravCheck = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        yrotdeg = transform.localEulerAngles.y;
        xrotdeg = transform.localEulerAngles.x;
        zrotdeg = transform.localEulerAngles.z;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            collision = true;
        }
    }
    IEnumerator waitfupdate()
    {
        yield return new WaitForFixedUpdate();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            waitfupdate();
            if (other.gameObject.tag == "GravBox1")
            {
                if (collision == true && gravCheck == false && Input.GetKeyDown(gravityKey))
                {
                    if (zrotdeg <= 90.01 && zrotdeg >= 89.99)
                    {
                        Physics.gravity = gravtonegaY;
                        Player.transform.rotation = Quaternion.Euler(0, yrotdeg, 0);
                        gravCheck = true;
                    }
                    else if (zrotdeg <= 270.1 && zrotdeg >= 169.9)
                    {
                        Physics.gravity = gravtonegaY;
                        Player.transform.rotation = Quaternion.Euler(0, yrotdeg, 0);
                        gravCheck = true;
                    }
                    else
                    {
                        Debug.Log("Error1");
                        Debug.Log(zrotdeg);
                        gravCheck = true;
                    }
                }
                else if (collision == true && gravCheck == true && Input.GetKeyDown(gravityKey))
                {

                    if (zrotdeg <= 0.01 && zrotdeg >= -0.01)
                    {
                        Physics.gravity = gravtoX;
                        Player.transform.rotation = Quaternion.Euler(xrotdeg, 0, 90);
                        gravCheck = false;
                    }
                    else
                    {
                        gravCheck = false;
                        Debug.Log("Error2");
                        Debug.Log(zrotdeg);
                    }
                }
            }
            else if (other.gameObject.tag == "GravBox2")
            {
                if (collision == true && gravCheck == false && Input.GetKeyDown(gravityKey))
                {
                    if (xrotdeg <= 0.01 && xrotdeg >= -0.01)
                    {
                        Physics.gravity = gravtonegaZ;
                        Player.transform.rotation = Quaternion.Euler(-90, yrotdeg, zrotdeg);
                        gravCheck = true;
                    }
                    else
                    {
                        gravCheck = true;
                        Debug.Log("Error3");
                        Debug.Log(xrotdeg);
                    }
                }
                else if (collision == true && gravCheck == true && Input.GetKeyDown(gravityKey))
                {
                    if (yrotdeg <= 90.2 && yrotdeg >= 89.8 && zrotdeg <= 90.2 && zrotdeg >= 89.8)
                    {
                        Physics.gravity = gravtonegaY;
                        Player.transform.rotation = Quaternion.Euler(0, xrotdeg, 0);
                        gravCheck = false;
                    }
                    else if (yrotdeg <= -89.8 && yrotdeg >= -90.1 && zrotdeg <= -89.8 && zrotdeg >= -90.1)
                    {
                        Physics.gravity = gravtonegaY;
                        Player.transform.rotation = Quaternion.Euler(0, xrotdeg, 0);
                        gravCheck = false;
                    }
                    else if (yrotdeg <= 270.1 && yrotdeg >= 269.9 && zrotdeg <= 270.1 && zrotdeg >= 269.9)
                    {
                        Physics.gravity = gravtonegaY;
                        Player.transform.rotation = Quaternion.Euler(0, xrotdeg, 0);
                        gravCheck = false;
                    }
                    else
                    {
                        gravCheck = false;
                        Debug.Log("Error4");
                        Debug.Log(yrotdeg);
                        Debug.Log(zrotdeg);
                    }
                }
            }
            else if (other.gameObject.tag == "GravBox3")
            {
                if (collision == true && gravCheck == false && Input.GetKeyDown(gravityKey))
                {
                    if (Player.transform.rotation.eulerAngles.y <= 0.01 && Player.transform.rotation.eulerAngles.y >= -0.01)
                    {
                        Physics.gravity = gravtonegaZ;
                        Player.transform.rotation = Quaternion.Euler(xrotdeg, 90, 90);
                        gravCheck = true;
                    }
                    else if (Player.transform.rotation.eulerAngles.y <= 180.1 && Player.transform.rotation.eulerAngles.y >= 179.9)
                    {
                        Physics.gravity = gravtonegaZ;
                        Player.transform.rotation = Quaternion.Euler(xrotdeg, 90, 90);
                        gravCheck = true;
                    }
                    else
                    {
                        gravCheck = true;
                        Debug.Log("Error5");
                    }
                }
                else if (collision == true && gravCheck == true && Input.GetKeyDown(gravityKey))
                {
                    if (yrotdeg <= 90.2 && yrotdeg >= 89.8 && zrotdeg <= 90.2 && zrotdeg >= 89.8)
                    {
                        Physics.gravity = gravtoX;
                        Player.transform.rotation = Quaternion.Euler(xrotdeg, 0, 90);
                        gravCheck = false;
                    }
                    else if (yrotdeg <= -89.8 && yrotdeg >= -90.1 && zrotdeg <= -89.8 && zrotdeg >= -90.1)
                    {
                        Physics.gravity = gravtoX;
                        Player.transform.rotation = Quaternion.Euler(xrotdeg, 0, 90);
                        gravCheck = false;
                    }
                    else if (yrotdeg <= 270.1 && yrotdeg >= 269.9 && zrotdeg <= 270.1 && zrotdeg >= 269.9)
                    {
                        Physics.gravity = gravtoX;
                        Player.transform.rotation = Quaternion.Euler(xrotdeg, 0, 90);
                        gravCheck = false;
                    }
                    else
                    {
                        gravCheck = false;
                        Debug.Log("Error6");
                        Debug.Log(yrotdeg);
                        Debug.Log(zrotdeg);
                    }
                }
            }

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            collision = false;
        }
    }
}
