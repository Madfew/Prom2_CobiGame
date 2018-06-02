using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour {

	public int vida;

	void Start () {

		vida = 100;
	}


	void Update () {

		if (vida <= 0) {
			Debug.Log ("muerte");
		} else {
			Debug.Log (vida);
		}
	}
}
