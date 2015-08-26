using UnityEngine;
using System.Collections;


public class random : MonoBehaviour {


	float x;
	float y;
	float z;
	Vector3 pos;


	IEnumerator Start()
	{



		while (gameObject.activeSelf) {
			yield return new WaitForSeconds (10.0f);
			y=10.0f;

			x = Random.Range (-288.0f, -190.0f);
			//z=0.0f;
			////y = Random.Range (-11.0f, -0.5f);
			z = Random.Range (-80.6f, 50.04f);
			pos = new Vector3 (x, y, z);
			transform.position = pos;

		}
	}



	//for collision
	void OnTriggerEnter(Collider other) {
		
		if (other.gameObject.CompareTag ("Person")) {

			Application.LoadLevel("Level1");

		}
	

	}


	IEnumerator goChange(){

		while (gameObject.activeSelf) {
			yield return new WaitForSeconds (5.0f);

			
			y=10.0f;
			
			x = Random.Range (-288.0f, -190.0f);
			z=0.0f;
			////y = Random.Range (-11.0f, -0.5f);
			//z = Random.Range (-104.6f, -10.04f);
			pos = new Vector3 (x, y, z);
			transform.position = pos;
			gameObject.SetActive(true);
		}

	}


}
