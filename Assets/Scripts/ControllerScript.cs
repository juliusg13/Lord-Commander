using UnityEngine;
using System.Collections;

public class ControllerScript : MonoBehaviour {
	GameObject Lord;
	// Use this for initialization
	void Start () {
		Lord = GameObject.FindGameObjectWithTag("Lord");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void callChangeJustShotBool(){
		changeJustShotBool();
		Invoke("changeJustShotBool", 0.15f);
	}
	void changeJustShotBool(){
		//Debug.Log ("fuu");
		
		if (Lord.GetComponent<Animator> ().GetBool ("JustShot") == true) {
			Lord.GetComponent<Animator> ().SetBool ("JustShot", false);
		} else {
			Lord.GetComponent<Animator> ().SetBool ("JustShot", true);
		}
	}
}
