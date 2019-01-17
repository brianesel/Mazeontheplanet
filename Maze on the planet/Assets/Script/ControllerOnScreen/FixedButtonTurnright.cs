using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FixedButtonTurnright : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{


    [HideInInspector]
    public bool ButtonTurnrightPressed;

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
      
        
            ButtonTurnrightPressed = true;
       
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        
            ButtonTurnrightPressed = false;
       
    }
}
