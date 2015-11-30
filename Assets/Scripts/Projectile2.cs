using UnityEngine;
using System.Collections;

public class Projectile2 : MonoBehaviour {
	//public Transform myTarget;
	//public float speed = 1;
	public GameObject target;
	public float speed = 10;
	GameObject Lord;
	private ControllerScript controller;

	float MonsterSpeed;

	// Use this for initialization
	void Start () {
		controller = GameObject.FindGameObjectWithTag ("Controller").GetComponent<ControllerScript> ();
		Lord = GameObject.FindGameObjectWithTag("Lord");
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
		bool lol = false;
		if (other.gameObject.tag == "Monster" ) {
			other.gameObject.GetComponent<MonsterBehaviour>().health -= 1;

			if(other.gameObject.GetComponent<MonsterBehaviour>().health == 0){
				lol = true;
				Destroy(other.gameObject);
				//Lord.GetComponent<Animator>().SetBool("JustShot", true);
			}
			if(lol == true) controller.increaseCoinage(3);
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
