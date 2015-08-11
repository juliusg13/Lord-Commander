using UnityEngine;
using System.Collections;

public class LordAttack : MonoBehaviour {
	public GameObject Projectile;
	public float fireRate;
	public double nextShot;
	public bool allowFire;
	public bool fireOK;
	public Projectile proj;

	//Animator animator;
	GameObject Lord;
	GameObject CurrentMonster;
	public double JustShotDelay;
	// Use this for initialization
	void Start () {
		//fireRate = 0.5f;
		nextShot = 0.9;
		fireOK = true;
		//animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate() {

	}

	void OnMouseDown(){
		//float x = this.transform.position.x;
		//float y = this.transform.position.y;

		if (this.gameObject.tag == "Monster") {

			//changeJustShotBool();
			//Invoke("changeJustShotBool", 0.5f);

			//Debug.Log ("fuu1");
			if (allowFire) { //Locks out for a time corresponding to fireRate
				CurrentMonster = this.gameObject;

				StartCoroutine(Fire ());					//For IEnumerator.. not a function
			}
		}
	}

/*	void changeJustShotBool(){
		//Debug.Log ("fuu");
		Lord = GameObject.FindGameObjectWithTag("Lord");
		if (Lord.GetComponent<Animator> ().GetBool ("JustShot") == true) {
			Lord.GetComponent<Animator> ().SetBool ("JustShot", false);
		} else {
			Lord.GetComponent<Animator> ().SetBool ("JustShot", true);
		}
		Destroy(CurrentMonster);
	} */

	IEnumerator Fire()
	{
		allowFire = false;
		GameObject newShot = (GameObject)Instantiate (Projectile, new Vector3 (0.52f, -0.18f, -1f), transform.rotation);
		proj.projectile = newShot;
		proj.target = CurrentMonster;

		//newShot.GetComponent<Projectile> ().rb = newShot.GetComponent<Rigidbody2D> ().AddForce (200);
		//newShot.GetComponent<Projectile> ().target = CurrentMonster;
		//Debug.Log ("wat");
		//newShot.GetComponent<Projectile> ().initialPos = new Vector3 (0.52f, -0.18f, -1f);
		//newShot.GetComponent<Projectile> ().radius = this.GetComponent<CircleCollider2D> ().radius;
		//Debug.Log ("fuu");

		yield return new WaitForSeconds (fireRate);
		//Debug.Log ("fuu1");
		Destroy(CurrentMonster);
		allowFire = true;

	}
}
