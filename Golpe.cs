using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golpe : MonoBehaviour {

	public GameObject personaje;
	public float vidaPersonaje;

	void Update () {
		
		vidaPersonaje = personaje.GetComponent<Personaje> ().vida;

		if (vidaPersonaje <= 0) {
			Debug.Log ("muerte");
		} else {
			Debug.Log (vidaPersonaje);
		}
			
	}
		
	public void OnClick() {

		if (vidaPersonaje >= 0) {
			vidaPersonaje = vidaPersonaje - 20;
		} else {
			vidaPersonaje = 0;
		}

	}
}
