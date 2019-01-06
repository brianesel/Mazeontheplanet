using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class FixedButtonForward : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{


    [HideInInspector]
    public bool ButtonForwardPressed;

    // Use this for initialization
    void Start()
    {
      ButtonForwardPressed = false;
}

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
            ButtonForwardPressed = true;
       
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ButtonForwardPressed = false;
    }
}
