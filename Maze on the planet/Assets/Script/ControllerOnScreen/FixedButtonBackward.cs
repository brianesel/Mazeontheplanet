using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FixedButtonBackward : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{

    [HideInInspector]
    public bool ButtonBackPressed;

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
      
            ButtonBackPressed = true;
       
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        
            ButtonBackPressed = false;
        
    }
}
