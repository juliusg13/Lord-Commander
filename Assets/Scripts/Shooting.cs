using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {
	public GameObject Projectile;
	string monsterTag = "Monster";
	float distance;
	//float range = 3.0f;
	Transform target = null;

	public int initialSpeed = 500;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (target);
	
	}

	void OnMouseDown() {
		//Debug.Log ("does shoot");
		target = this.transform;
		Shoot ();
		//Debug.Log ("shot away");
	}

	void Shoot() {
		//Debug.Log ("Enters Shoot");
		GameObject newShot = (GameObject)Instantiate (Projectile, new Vector3 (0.52f, -0.18f, -1f), transform.rotation);
		//Debug.Log ("does new shot");
		newShot.GetComponent<Rigidbody2D> ().AddForce (10f * initialSpeed);
	}
}
