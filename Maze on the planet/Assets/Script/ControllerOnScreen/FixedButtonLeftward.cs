using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FixedButtonLeftward : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{


    [HideInInspector]
    public bool ButtonLeftPressed;

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
            ButtonLeftPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
       
            ButtonLeftPressed = false;
        
    }
}
