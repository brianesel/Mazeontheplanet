using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winscript : MonoBehaviour {

    public GameObject winText;
    public Transform congratText;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(winText);
            winText.transform.position = congratText.transform.position;
            winText.transform.eulerAngles = congratText.transform.eulerAngles;
        }
    }
}
