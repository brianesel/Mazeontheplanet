using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cameraswitch : MonoBehaviour {
    public string camerainuse;
    public KeyCode cameraSwitchKey;
    public Camera camera1;
    public Camera camera2;
    // Use this for initialization
    void Start () {
        camerainuse = "3rdtpersoncamera";

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(cameraSwitchKey) && camerainuse == "3rdtpersoncamera")
        { camerainuse = "1sttpersoncamera";}
        else if (Input.GetKeyDown(cameraSwitchKey) && camerainuse == "1sttpersoncamera") { camerainuse = "3rdtpersoncamera"; }

        if (camerainuse == "1sttpersoncamera")
        {
            camera1.enabled = false;
            camera2.enabled = true;
        }
        else if (camerainuse == "3rdtpersoncamera") {
            camera1.enabled = true;
            camera2.enabled = false;
        }

	}
}
