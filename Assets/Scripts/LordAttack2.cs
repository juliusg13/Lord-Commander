using UnityEngine;
using System.Collections;

public class LordAttack2 : MonoBehaviour {
	public GameObject Projectile;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() {

	}

	void OnMouseDown() {
		if (this.gameObject.tag == "Monster") {

			//Rigidbody2D newShot = Instantiate (Projectile, new Vector3 (0.52f, -0.18f, -1f), transform.rotation) as Rigidbody2D;
			//newShot.AddForce = new Vector2(transform.forward * 200f);

			GameObject projectile = Instantiate( Projectile, new Vector3 (0.52f, -0.18f, -1f), transform.rotation ) as GameObject;
			projectile.GetComponent<Projectile2>().target = this.gameObject;
			float speed = projectile.GetComponent<Projectile2>().speed;
			//Vector2 force = new Vector2(speed, 0);
			Vector2 force = transform.forward * speed;

			projectile.GetComponent<Rigidbody2D>().AddForce(force, ForceMode2D.Impulse);
		}
	}
}
