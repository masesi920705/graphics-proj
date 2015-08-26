using UnityEngine;
using System.Collections;

public class Sounds: MonoBehaviour {
	
	public CharacterController controller; 
	public AudioClip[] concrete; 
	private bool step = true; 
	private float audioStepLengthWalk = 0.7f; 
	private float audioStepLengthRun = 0.25f;

	/*public AudioClip[] wood; 
	public AudioClip[] dirt; 
	public AudioClip[] metal; 
	public AudioClip[] glass; 
	public AudioClip[] sand; 
	public AudioClip[] snow; 
	public AudioClip[] floor; 
	public AudioClip[] grass;
*/

	/*
	void Start(){
		controller = GetComponent<CharacterController> ();

	}*/

	void OnControllerColliderHit ( ControllerColliderHit hit) {
		Application.LoadLevel("Level2");
		if (controller.isGrounded && controller.velocity.magnitude < 10 && controller.velocity.magnitude > 5 && hit.gameObject.tag == "Untagged" && step == true ) {
			WalkOnConcrete();
		} else if (controller.isGrounded && controller.velocity.magnitude > 8 && hit.gameObject.tag == "Ground" && step == true || controller.isGrounded && controller.velocity.magnitude > 10 && hit.gameObject.tag == "Untagged" && step == true) {
			RunOnConcrete();
		}
	}
	
	IEnumerator WaitForFootSteps(float stepsLength) { 
		step = false; 
		yield return new WaitForSeconds(stepsLength); 
		step = true; } 
	
	/////////////////////////////////// CONCRETE //////////////////////////////////////// 
	
	void WalkOnConcrete() {
		GetComponent<AudioSource>().clip = concrete[Random.Range(0, concrete.Length)];
		GetComponent<AudioSource>().volume = 1.0f;
		GetComponent<AudioSource>().Play();
		StartCoroutine(WaitForFootSteps(audioStepLengthWalk));
	}
	
	void RunOnConcrete() {
		GetComponent<AudioSource>().clip = concrete[Random.Range(0, concrete.Length)];
		GetComponent<AudioSource>().volume = 1.0f;
		GetComponent<AudioSource>().Play();
		StartCoroutine(WaitForFootSteps(audioStepLengthRun));
	}
}