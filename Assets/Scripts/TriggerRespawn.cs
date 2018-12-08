using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRespawn : MonoBehaviour {
		[SerializeField]
		GameObject GUITexture; 

		[SerializeField]
		Vector3 Position;
	void OnTriggerEnter (Collider other)
	{
		Debug.Log ("entered trigger");	                             
		if(other.gameObject.tag == "Player")
		{                                        
		Instantiate(GUITexture, new Vector3(0, 2, 34), Quaternion.identity);  
		Destroy(GUITexture);    
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

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class TriggerRespawn : MonoBehaviour {
// 		[SerializeField]
// 		GameObject GUITexture; 

// 		[SerializeField]
// 		Transform Position;
// 	void OnTriggerEnter (Collider other)
// 	{
// 		Debug.Log ("entered trigger");	                             
// 		if(other.gameObject.tag == "Player")
// 		{                                        
// 		Instantiate(GUITexture, this.transform, true);  
// 		Destroy(GUITexture);    
// 		}
// 	}
// 	void OnTriggerStay (Collider other)
// 	{	
// 		Debug.Log ("in trigger");
// 	}
// 	void OnTriggerExit (Collider other)
// 	{
// 		Debug.Log ("exited trigger");
// 	}
// }
