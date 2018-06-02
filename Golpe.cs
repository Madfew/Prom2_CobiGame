using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golpe : MonoBehaviour {

	public GameObject personaje;

	void Update () {
			
	}
		
	public void OnClick() {

		if (personaje.GetComponent<Personaje> ().vida >= 0) {
			personaje.GetComponent<Personaje> ().vida = personaje.GetComponent<Personaje> ().vida - 20;
		} else {
			personaje.GetComponent<Personaje> ().vida = 0;
		}

	}
}
