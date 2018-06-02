using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golpe : MonoBehaviour {

	public GameObject personaje;
	int	vidaPersonaje;
    public bool Golpeado;

	void Start () {
		
		vidaPersonaje = personaje.GetComponent<Personaje> ().vida;
			
	}

	public void OnClick() {
		vidaPersonaje = vidaPersonaje - 20;
        Debug.Log(vidaPersonaje);
        Golpeado = true;
	}
}
