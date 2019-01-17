using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class FixedButtonGrav : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [HideInInspector]
    public int GravButtonPressed;

    // Use this for initialization
    void Start()
    {
        GravButtonPressed = 0;
    }
    
    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (GravButtonPressed == 0)
        {
            GravButtonPressed = 1;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (GravButtonPressed == 1) {
            GravButtonPressed = 2;
        }
    }
}