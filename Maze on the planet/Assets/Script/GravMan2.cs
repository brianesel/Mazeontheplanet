using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravMan2 : MonoBehaviour
{
    private GameObject condition;
    public GameObject Player;
    public float lerpTime = 3f;
    public bool collision = false;
    private int transforming;
    private string gravCheck;
    public KeyCode gravityKey;
    public bool gravityKeyPressed;
    private Vector3 gravtoX = new Vector3(9.81f,0,0);
    private Vector3 gravtonegaY= new Vector3(0, -9.81f, 0);
    private Vector3 gravtonegaZ= new Vector3(0, 0, -9.81f);
    private float yrotdeg;
    private float xrotdeg;
    private float zrotdeg;
    private string collideGravBox;
    // Use this for initialization
    void Start()
    {
       gravCheck= "-y";
        gravityKeyPressed = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(gravityKey)) { gravityKeyPressed = true; }

         yrotdeg = transform.localEulerAngles.y;
         xrotdeg = transform.localEulerAngles.x;
        zrotdeg = transform.localEulerAngles.z;
        if (collideGravBox=="GravBox1") {
            if (collision == true && gravCheck == "x" && gravityKeyPressed == true && Physics.gravity == gravtoX)
            {

                Physics.gravity = gravtonegaY;
                Player.transform.rotation = Quaternion.Euler(0, -xrotdeg, 0);
                gravCheck = "-y";
                Debug.Log("Error1");
                Debug.Log(zrotdeg);
                gravityKeyPressed = false;

            }
            else if (collision == true && gravCheck == "-y" && gravityKeyPressed == true && Physics.gravity == gravtonegaY)
            {


                Physics.gravity = gravtoX;
                Player.transform.rotation = Quaternion.Euler(-yrotdeg, 0, 90);
                gravCheck = "x";


                Debug.Log("Error2");
                Debug.Log(zrotdeg);
                gravityKeyPressed = false;
            }
        }
        else if (collideGravBox=="GravBox2") {
            if (collision == true && gravCheck == "-y" && gravityKeyPressed == true && Physics.gravity == gravtonegaY)
            {

                Physics.gravity = gravtonegaZ;
                Player.transform.Rotate(90f, 0f, 0f, Space.World);
                gravCheck = "-z";

                Debug.Log("Error3");
                Debug.Log(xrotdeg);
                gravityKeyPressed = false;
            }

            else if (collision == true && gravCheck == "-z" && gravityKeyPressed == true && Physics.gravity == gravtonegaZ)
            {

                Physics.gravity = gravtonegaY;
                Player.transform.Rotate(-90f, 0f, 0f, Space.World);
                gravCheck = "-y";
                Debug.Log("Error4");
                Debug.Log(yrotdeg);
                Debug.Log(zrotdeg);
                gravityKeyPressed = false;
            }
        }
        else if (collideGravBox=="GravBox3") {
            if (collision == true && gravCheck == "x" && gravityKeyPressed == true && Physics.gravity == gravtoX)
            {
                Physics.gravity = gravtonegaZ;
                Player.transform.rotation = Quaternion.Euler(xrotdeg, 90, 90);
                gravCheck = "-z";
                Debug.Log("Error5");
                gravityKeyPressed = false;
            }
            else if (collision == true && gravCheck == "-z" && gravityKeyPressed == true && Physics.gravity == gravtonegaZ)
            {

                Physics.gravity = gravtoX;
                Player.transform.rotation = Quaternion.Euler(xrotdeg, 0, 90);
                gravCheck = "x";

                Debug.Log("Error6");
                Debug.Log(yrotdeg);
                Debug.Log(zrotdeg);
                gravityKeyPressed = false;
            }
        }
        else { Debug.Log("No collide gravbox"); }

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
         
            if (other.gameObject.tag == "GravBox1")
            {
                collideGravBox = "GravBox1";
            }
            else if (other.gameObject.tag == "GravBox2")
            {
                collideGravBox = "GravBox2";
            }

            else if (other.gameObject.tag == "GravBox3")
            {
                collideGravBox = "GravBox3";
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
