using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelOnCollision : MonoBehaviour 
{	
	[SerializeField]
	string leTag;
		private void OnCollisionEnter(Collision collision)
		{
			if (collision.collider.tag == leTag)
				SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
}
