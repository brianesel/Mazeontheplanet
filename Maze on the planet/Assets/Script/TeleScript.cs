using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleScript : MonoBehaviour {
    public Transform teleLoc;
    public GameObject Player;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
        
        if (other.gameObject.tag == "TeleSphere")
        { 
            Player.transform.position = teleLoc.transform.position;
            Player.transform.eulerAngles = teleLoc.transform.eulerAngles;
            Physics.gravity = new Vector3(0,-9.81f,0);
        }
	}
    
}
