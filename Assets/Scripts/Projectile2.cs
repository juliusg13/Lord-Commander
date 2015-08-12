using UnityEngine;
using System.Collections;

public class Projectile2 : MonoBehaviour {
	public Transform target;
	public float speed;
	public float radius;
	public Vector3 initialPos;
	public GameObject First;
	public GameObject Second;
	public GameObject Third;
	public GameObject Forth;
	public GameObject Fifth;
	public GameObject Sixth;
	public GameObject Seventh;
	public GameObject Eighth;
	//public float speed = 1;

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Monster" ) {
			Destroy (this.gameObject);
		}
		
		
	}
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

	void FixedUpdate (){
		
		//while (target != null) {
		if (this.gameObject.tag == "BeerAoE") {
			if(First != null)
			{
				First.transform.Translate(new Vector3(0,speed*Time.deltaTime,0));
			}
			if(Second != null)
			{
				Second.transform.Translate(new Vector3(speed*Time.deltaTime, 0, 0));
			}
			if(Third != null)
			{
				Third.transform.Translate(new Vector3(speed*0.7f*Time.deltaTime, speed*0.7f*Time.deltaTime, 0));
			}
			if(Forth != null)
			{
				Forth.transform.Translate(new Vector3(0,-speed*Time.deltaTime,0));
			}
			if(Fifth != null)
			{
				Fifth.transform.Translate(new Vector3(-speed*Time.deltaTime,0,0));
			}
			if(Sixth != null)
			{
				Sixth.transform.Translate(new Vector3(-speed*0.7f*Time.deltaTime,-speed*0.7f*Time.deltaTime,0));
			}
			if(Seventh != null)
			{
				Seventh.transform.Translate(new Vector3(speed*0.7f*Time.deltaTime,-speed*0.7f*Time.deltaTime,0));
			}
			if(Eighth != null)
			{
				Eighth.transform.Translate(new Vector3(-speed*0.7f*Time.deltaTime,speed*0.7f*Time.deltaTime,0));
			}
		}
		if (target == null && this.gameObject.tag != "BeerAoE") {				// if groupie does no longer exists then destroy the note that is following it
			Destroy (this.gameObject);
		}
		if (target != null && this.gameObject.tag != "BeerAoE") {
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, target.transform.position, step);
		}
		if ((transform.position.x > initialPos.x + 3*radius || transform.position.y > initialPos.y + 3*radius || transform.position.x < initialPos.x - 3*radius || transform.position.y < initialPos.y - 3*radius)&& this.gameObject.tag != "BeerAoE") {
			Destroy (this.gameObject);
		}
	}
}
