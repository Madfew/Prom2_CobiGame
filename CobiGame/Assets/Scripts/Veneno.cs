using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veneno : MonoBehaviour {

	public GameObject personaje;
	float	vidaPersonaje;
	public float damageTime = 3f;

	void Start () {

		vidaPersonaje = personaje.GetComponent<Personaje> ().vida;

	}

	public void OnClick() {

		StartCoroutine ("DañoVeneno");
	}

	IEnumerator DañoVeneno() {

		float time = 0;
		while (time < damageTime) {
			time += Time.deltaTime;
			vidaPersonaje = vidaPersonaje - 0.01f;
            Debug.Log(vidaPersonaje);
			yield return null;
		}
	}
}
