using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Nepecahanas, Lai strada ar UI
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour {
	/*int kadri = 0;

	// Use this for initialization
	void Start () {
		Debug.Log ("Programma yika starteta!");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Kards" + kadri);
		kadri++;

		if(kadri == 10){
			Debug.Log ("Tu sasniedzi 10. kadru!");
	}
}*/
	//mainigas, kra uzglabas tekst no input filed
	private string teksts;
	//Lauks, kura ievada tekstu
	public GameObject ievadesLauks;
	//text object, kura attelos tekstu pec pogas nospiesanas
	public GameObject tekstaAttelosana;
	//masiva ar izpejamajiem tekst sakumiem 
	private string[] varieanti = {"Sveiki ", "Labdien ", "Prieks Tevi redzet ", "Uzredesanos "};
	//mainigais uzgLabas random skaitli
	int nejausais;

	public void NolasitTekstu (){
		teksts = ievadesLauks.GetComponent<Text>().text;
		nejausais = Random.Range (0, varieanti.Length);
		tekstaAttelosana.GetComponent<Text> ().text = varieanti [nejausais] + teksts.ToUpper () + "!";
	}
}
