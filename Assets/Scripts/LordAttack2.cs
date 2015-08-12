using UnityEngine;
using System.Collections;

public class LordAttack2 : MonoBehaviour {
	public GameObject Projectile;



	public GameObject Note; //Returns an error because it is not initialized
	public GameObject BeerSpillSmall;
	public GameObject BeerSpillMedium;
	public GameObject BeerSpillBig;
	public float fireRate = 0.5f;
	public double nextShot = 0.9;
	public bool allowFire = true;
	public bool FireOK = true;
	public float slowing = 0;
	//public float radius = transform.GetComponent<CircleCollider2D>().radius;
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
			//GameObject projectile = Instantiate( Projectile, new Vector3 (0.52f, -0.18f, -1f), transform.rotation ) as GameObject;
			//projectile.GetComponent<Projectile2>().myTarget = this.transform;
			//Vector2 force = new Vector2(0f, 3f);
			//projectile.GetComponent<Rigidbody2D>().AddForce(force, ForceMode2D.Impulse);

			StartCoroutine(Fire (this.gameObject));
		}
	}

	IEnumerator Fire(GameObject Monster)
	{
		allowFire = false;
		GameObject newNote = (GameObject)Instantiate (Note, new Vector3 (0.52f , -0.18f, -1f), transform.rotation);
		
		
		GameObject groupie = Monster;
		if (groupie == null) {
			allowFire = true;
			
		} else {
			//Groupie_Behaviour gScript = groupie.GetComponent<Groupie_Behaviour> ();
			//if (gScript.drunk && this.gameObject.tag == "BarShootStraight") {
			//	ObjectsInRange.Remove (groupie);
			//	newNote.GetComponent<Note> ().target = ObjectsInRange.FirstOrDefault ();
			//} else {
		newNote.GetComponent<Projectile2> ().target = Monster.transform;
			//}
		//newNote.GetComponent<Projectile2> ().initialPos = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
			newNote.GetComponent<Projectile2> ().initialPos = new Vector3 (0.52f , -0.18f, -1f);
		newNote.GetComponent<Projectile2> ().radius = this.GetComponent<CircleCollider2D> ().radius;
			yield return new WaitForSeconds (fireRate);
			allowFire = true;
		}

	}
}
