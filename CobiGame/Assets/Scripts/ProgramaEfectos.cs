using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgramaEfectos : MonoBehaviour {

    [Header("Scripts")]
    Veneno veneno;
    Golpe golpe;
    Personaje player;

    [Header("Textos")]
    public GameObject textoBienvenida;
    public string escribirAqui;


	// Use this for initialization
	void Start () {
        textoBienvenida.GetComponent<Text>().text = escribirAqui.ToString();
        Debug.Log("Bienvenido, aquí tendrás dos botones para que puedas observar los efectos de cada uno.");

	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
