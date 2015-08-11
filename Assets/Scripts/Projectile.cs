using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	public float speed;
	public Vector3 initialPos;
	public GameObject target;
	public Rigidbody2D shot;

	public GameObject projectile;
	//public float radius;


	// Use this for initialization
	void Start () {
		//projectile.GetComponent<Rigidbody2D> ().AddForce (new Vector2(0f, 200f));
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position += Time.deltaTime * transform.forward * 200;

	}
	void FixedUpdate() {
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, target.transform.position, step);
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Destroy" ) {
			Destroy (this.gameObject);
		}
	}
}
