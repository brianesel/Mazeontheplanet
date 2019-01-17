using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ThirdPersonInput : MonoBehaviour {

    protected GravMan2 GravControl;
    
    protected movementimple movecheck;
   
    protected Rotate turncheck;

    public FixedButtonGrav GravButton;

    public FixedButtonForward forwardButton;

    public FixedButtonBackward backwardButton;

    public FixedButtonLeftward leftwardButton;

    public FixedButtonRightWard rightwardButton;

    public FixedButtonTurnleft leftturnButton;

    public FixedButtonTurnright rightturnButton;
    
    void Start()
    {
        GravControl = GetComponent<GravMan2>();
        movecheck = GetComponent<movementimple>();
        turncheck = GetComponent<Rotate>();
    }
    void FixedUpdate()
    {
        movecheck.forwardKeyPress=forwardButton.ButtonForwardPressed ;

        movecheck.backwardKeyPress = backwardButton.ButtonBackPressed;

        movecheck.rightwardKeyPress = rightwardButton.ButtonRightPressed;

        movecheck.leftwardKeyPress = leftwardButton.ButtonLeftPressed;

        turncheck.rotleftbuttonpress = leftturnButton.ButtonTurnleftPressed;

        turncheck.rotrightbuttonpress = rightturnButton.ButtonTurnrightPressed;


        if (GravButton.GravButtonPressed == 2)
        {
            GravControl.gravityKeyPressed = true;
            GravButton.GravButtonPressed = 0;
        }
    }

}
