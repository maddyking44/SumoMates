using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWin : MonoBehaviour {
		[SerializeField]
		GameObject GUITexture; 

		[SerializeField]
		Vector3 Position;
	void OnTriggerEnter (Collider other)
	{
		Debug.Log ("entered trigger");	                             
		if(other.gameObject.tag == "SpherePlayer")
		{                                        
		Instantiate(GUITexture, new Vector3(-2, 5, 34), Quaternion.identity);      
		// Destroy(other.gameObject);  //only destroys body
		}
	}
	void OnTriggerStay (Collider other)
	{	
		Debug.Log ("in trigger");
	}
	void OnTriggerExit (Collider other)
	{
		Debug.Log ("exited trigger");
	}
}
