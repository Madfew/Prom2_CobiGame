using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golpe : MonoBehaviour {

	public GameObject personaje;
	int	vidaPersonaje;

	void Start () {
		
		vidaPersonaje = personaje.GetComponent<Personaje> ().vida;
			
	}

	void OnClick() {

		vidaPersonaje = vidaPersonaje - 20;
	}
}
