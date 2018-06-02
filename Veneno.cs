using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veneno : MonoBehaviour {

	public GameObject personaje;
	int	vidaPersonaje;
	public float damageTime = 5f;

	void Start () {

		vidaPersonaje = personaje.GetComponent<Personaje> ().vida;

	}

	void OnClick() {

		StartCoroutine ("DañoVeneno");
	}

	IEnumerator DañoVeneno() {

		float time = 0;
		while (time < damageTime) {
			time += Time.deltaTime;
			vidaPersonaje = vidaPersonaje - 5;
			yield return null;
		}
	}
}
