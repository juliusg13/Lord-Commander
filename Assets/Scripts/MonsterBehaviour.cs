using UnityEngine;
using System.Collections;

public class MonsterBehaviour : MonoBehaviour {
		
	public float moveSpeed;
	public float health;

	//private bool isCollision;
	
	public Quaternion rotation = Quaternion.identity;
//	string direction = "south"; 

	
	// Use this for initialization
	void Start () {
		health = 2;
		//	controller = GameObject.FindGameObjectWithTag ("GameController").GetComponent<Controller>();
		//currentSpeed = moveSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void FixedUpdate (){
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (transform.localScale.x * 0, transform.localScale.y * -moveSpeed);	
	}

/*	void OnTriggerStay2D(Collider2D other){
		if (other.tag == "Wall") {
			isCollision = true;
		}
	}
	void LateUpdate(){
		isCollision = false;
	}
	*/
	
}
	
