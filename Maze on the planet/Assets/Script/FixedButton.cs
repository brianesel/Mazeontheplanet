using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class FixedButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [HideInInspector]
    public bool Pressed;
    private bool Pressing;

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
        if (Pressing == false)
        {
            Pressed = true;
            Pressing = true;
        }
        else { }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
        Pressing = false;
    }
}