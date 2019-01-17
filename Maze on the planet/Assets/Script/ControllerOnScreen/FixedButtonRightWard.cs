using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FixedButtonRightWard : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{


    [HideInInspector]
    public bool ButtonRightPressed;

    // Use this for initialization
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
       
        
            ButtonRightPressed = true;
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        
            ButtonRightPressed = false;
        
    }
}
