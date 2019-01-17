using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FixedButtonTurnleft : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{


    [HideInInspector]
    public bool ButtonTurnleftPressed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {


        ButtonTurnleftPressed = true;

    }

    public void OnPointerUp(PointerEventData eventData)
    {

        ButtonTurnleftPressed = false;

    }
}
