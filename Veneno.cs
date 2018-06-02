using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veneno : MonoBehaviour {

	public GameObject personaje;

	public float damageTime = 5f;

	void Update () {
	
	}

	public void OnClick() {

		if (personaje.GetComponent<Personaje> ().vida >= 0) {
			StartCoroutine ("DañoVeneno");
		} else {
			personaje.GetComponent<Personaje> ().vida = 0;
		}
	}

	IEnumerator DañoVeneno() {

		float time = 0;
		while (time < damageTime) {
			time += 1f;
			personaje.GetComponent<Personaje> ().vida = personaje.GetComponent<Personaje> ().vida - 5;
			yield return null;
		}
	}
}
