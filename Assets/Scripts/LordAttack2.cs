using UnityEngine;
using System.Collections;

public class LordAttack2 : MonoBehaviour {
	public GameObject Projectile;
	public bool allowFire;
	GameObject CurrentMonster;
	public float fireRate;
	GameObject Controller;

	// Use this for initialization
	void Start () {
		fireRate = 0.5f;
		allowFire = true;
		Controller = GameObject.FindGameObjectWithTag("Controller");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() {

	}

	void OnMouseDown() {
		if (this.gameObject.tag == "Monster") {

			if (allowFire) { //Locks out for a time corresponding to fireRate

				//callChangeJustShotBool();

				Controller.gameObject.GetComponent<ControllerScript>().Invoke("callChangeJustShotBool", 0);


				CurrentMonster = this.gameObject;
				StartCoroutine(Fire ());					//For IEnumerator.. not a function
			}

					//Rigidbody2D newShot = Instantiate (Projectile, new Vector3 (0.52f, -0.18f, -1f), transform.rotation) as Rigidbody2D;
					//newShot.AddForce = new Vector2(transform.forward * 200f);

		//	GameObject projectile = Instantiate( Projectile, new Vector3 (0.52f, -0.18f, -1f), transform.rotation ) as GameObject;
		//	projectile.GetComponent<Projectile2>().target = this.gameObject;
		//	float speed = projectile.GetComponent<Projectile2>().speed;
					//Vector2 force = new Vector2(speed, 0);
		//	Vector2 force = transform.forward * speed;

		//	projectile.GetComponent<Rigidbody2D>().AddForce(force, ForceMode2D.Impulse);
		}
	}
	IEnumerator Fire(){

		allowFire = false;

		GameObject projectile = Instantiate( Projectile, new Vector3 (0.52f, -0.18f, -1f), transform.rotation ) as GameObject;
		projectile.GetComponent<Projectile2>().target = this.gameObject;
		float speed = projectile.GetComponent<Projectile2>().speed;
		Vector2 force = transform.forward * speed;
		projectile.GetComponent<Rigidbody2D>().AddForce(force, ForceMode2D.Impulse);

		yield return new WaitForSeconds (fireRate);
		allowFire = true;
	}


}
