﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionforGravChange : MonoBehaviour {
   
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
        if (other.gameObject.tag == "Player") {
            bool condition = other.gameObject.GetComponent<GravityManipulation>().collision;
            
        }
	}
}
