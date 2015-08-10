using UnityEngine;
using System.Collections;

public class LordAttack : MonoBehaviour {


	//Animator animator;
	GameObject Lord;
	GameObject CurrentMonster;
	public double JustShotDelay;
	// Use this for initialization
	void Start () {
		//animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown(){
		float x = this.transform.position.x;
		float y = this.transform.position.y;

		if (this.gameObject.tag == "Monster") {
			//animator.SetBool("JustShot", true);

			//JustShotWait(1);
			//Invoke("changeJustShotBool", 1);
			changeJustShotBool();
			Invoke("changeJustShotBool", 0.5f);
			CurrentMonster = this.gameObject;
			//

		}
	}

	void changeJustShotBool(){
		//Debug.Log ("fuu");
		Lord = GameObject.FindGameObjectWithTag("Lord");
		if (Lord.GetComponent<Animator> ().GetBool ("JustShot") == true) {
			Lord.GetComponent<Animator> ().SetBool ("JustShot", false);
		} else {
			Lord.GetComponent<Animator> ().SetBool ("JustShot", true);
		}
		Destroy(CurrentMonster);
	}
}
