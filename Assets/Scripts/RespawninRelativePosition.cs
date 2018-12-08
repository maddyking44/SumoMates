using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawninRelativePosition : MonoBehaviour {
   [SerializeField]
    private GameObject ari; // Assign a prefab to this in the inspector
    
    [SerializeField]
    private Transform ariPosition; // grab objects's position
	void OnTriggerEnter (Collider other)
	{
		Debug.Log ("entered trigger");	                             
		if(other.gameObject.tag == "Player")
		{                                        
          InstantiateObject();
        //   Destroy(ari);  
		}
	}

    private void InstantiateObject()
    {
        GameObject ariPrefab = Instantiate(ari) as GameObject; // creating a local game object to store the    instantiated object and then casting it to a Gamebject
    
    ariPrefab.name = "Ari"; // Setting prefab name in hierarchy
    ariPrefab.transform.position = new Vector3(3, 12, 24); // Setting the position of the prefab to "arrowPosition"
    }
}
