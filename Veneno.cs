using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veneno : MonoBehaviour {

	public GameObject personaje;
	public float vidaPersonaje;
	public float damageTime = 2f;

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
			StartCoroutine ("DañoVeneno");
		} else {
			vidaPersonaje = 0;
		}
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
