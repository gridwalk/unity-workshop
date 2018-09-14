using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour {

	private bool opening = false;
	private bool closing = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if( opening ){
			foreach (Transform child in transform) {

				if( child.name == "Rectangle03" ){
        	child.position += Vector3.left * 0.02F;


        	if( child.position[0] < 44.2 ){
        		opening = false;
        	}
				}

				if( child.name == "Rectangle09" ){
        	child.position -= Vector3.left * 0.02F;
				}
    	}	
		}

		if( closing ){

			foreach (Transform child in transform) {

				if( child.name == "Rectangle03" ){
        	child.position -= Vector3.left * 0.02F;

        	Debug.Log(child.position[0]);
        	if( child.position[0] > 45.5 ){
        		closing = false;
        	}
				}

				if( child.name == "Rectangle09" ){
        	child.position += Vector3.left * 0.02F;
				}
    	}	
		}

	}

	void OnTriggerEnter(Collider other){
		opening = true;
		closing = false;
  }

  void OnTriggerExit(Collider other){
		closing = true;
		opening = false;
  }
}
