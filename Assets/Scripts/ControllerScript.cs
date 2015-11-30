using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ControllerScript : MonoBehaviour {
	GameObject Lord;
	public int Coinage;
	public Text CoinageText;

	// Use this for initialization
	void Start () {
		Coinage = 0;

		Lord = GameObject.FindGameObjectWithTag("Lord");
		CoinageText.text = "Coinage: " + Coinage.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void callChangeJustShotBool(){
		changeJustShotBool();
		Invoke("changeJustShotBool", 0.15f);
	}
	void changeJustShotBool(){
		//Debug.Log ("fuu");
		
		if (Lord.GetComponent<Animator> ().GetBool ("JustShot") == true) {
			Lord.GetComponent<Animator> ().SetBool ("JustShot", false);
		} else {
			Lord.GetComponent<Animator> ().SetBool ("JustShot", true);
		}
	}
	public void increaseCoinage(int money){
		Coinage += money;
		CoinageText.text = "Coinage: " + Coinage.ToString ();

	}
}
