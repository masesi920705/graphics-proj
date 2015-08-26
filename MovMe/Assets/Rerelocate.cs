using UnityEngine;
using System.Collections;

public class Rerelocate : MonoBehaviour {
	float x;
	float y;
	float z;
	Vector3 pos;
	// Use this for initialization

	
	//for collision
	IEnumerator Start() {
		
		while (gameObject.activeSelf) {
			yield return new WaitForSeconds (15.0f);
			y=5.0f;
			
			x = Random.Range (-288.0f, -190.0f);
			//z=0.0f;
			////y = Random.Range (-11.0f, -0.5f);
			z = Random.Range (-50.6f, 50.04f);
			pos = new Vector3 (x, y, z);
			transform.position = pos;
			
		}
	}
}
