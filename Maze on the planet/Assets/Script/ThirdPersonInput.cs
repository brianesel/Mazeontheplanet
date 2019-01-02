using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonInput : MonoBehaviour {

    protected GravMan2 GravControl;
    public FixedButton GravButton;
    // Use this for initialization
    void Start () {
        GravControl = GetComponent<GravMan2>();
	}

    // Update is called once per frame
    void FixedUpdate () {
        GravControl.gravityKeyPressed = GravButton.Pressed;
    }

   
}
