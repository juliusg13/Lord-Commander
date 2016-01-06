using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ControllerScript : MonoBehaviour {
	GameObject Lord;
	public int Coinage;
	public int baseHP;
	public Text baseHPText;
	public Text CoinageText;

	// Use this for initialization
	void Start () {
		Coinage = 0;
		//baseHP = 10;

		Lord = GameObject.FindGameObjectWithTag("Lord");
		CoinageText.text = "Coinage: " + Coinage.ToString ();
		baseHPText.text = "Castle Strength: " + baseHP.ToString ();
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
	public void damageCastle(int damage){
		baseHP -= damage;
		baseHPText.text = "Castle Strength: " + baseHP.ToString ();

		if (baseHP == 0) {
			changeLevel ();
			//Invoke("changeLevel", 0.5f);
		}
	}
	void changeLevel(){
		if (baseHP == 0) {
			Application.LoadLevel ("GameOver");
		}
	}
}
