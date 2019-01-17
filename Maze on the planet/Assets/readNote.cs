using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class readNote : MonoBehaviour {
    public GameObject infoLetter;
    public GameObject noti;
    public KeyCode inforead;
    protected bool showinfoLetter; 
	// Use this for initialization
	void Start () {
        showinfoLetter = false;
        noti.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (showinfoLetter == false) {
            infoLetter.SetActive(false); }
        else{ infoLetter.SetActive(true); }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Info")
        {
            noti.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Info") {
            if (Input.GetKeyDown(inforead) && showinfoLetter == false)
            {
                showinfoLetter =true;
                noti.SetActive(false);
          
            }
            else if (Input.GetKeyDown(inforead) && showinfoLetter == true) {
                showinfoLetter = false;
                noti.SetActive(true);
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Info")
        {
            noti.SetActive(false);
        }
    }
}
