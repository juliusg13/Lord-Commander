using UnityEngine;
using System.Collections;

public class Projectile2 : MonoBehaviour {
	//public Transform myTarget;
	//public float speed = 1;
	public GameObject target;
	public float speed = 10;

	float MonsterSpeed;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//Vector2 targetDir = myTarget.position - transform.position;
		//float step = speed * Time.deltaTime;
		//Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
		//Debug.DrawRay(transform.position, newDir, Color.red);
		//transform.rotation = Quaternion.LookRotation(newDir);

	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Monster" ) {
			Destroy (this.gameObject);
		}
	}

	void FixedUpdate() {

		//MonsterSpeed = target.GetComponent<MonsterBehaviour> ().moveSpeed;
		Rigidbody2D RB = this.GetComponent<Rigidbody2D> ();
		//this.transform.forward = Vector3.Slerp (transform.forward, RB.velocity.normalized, Time.deltaTime);

		//Vector2 Tits = new Vector2 (0f, 0.6f);
		Vector2 FrontProj = transform.position;// + Vector3.forward;
		//Vector2 wat = (FrontProj + Tits) / 2;
		//RB.centerOfMass = wat;

		float step = speed * Time.deltaTime;
		
		transform.position = Vector3.MoveTowards (FrontProj, target.transform.position, step);
	}
}
