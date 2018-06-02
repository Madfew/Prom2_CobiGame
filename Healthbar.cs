using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthbar : MonoBehaviour {

    Image Healthbar
    float maxHealth = 100f;
    public static float health;

    // Use this for initialization
    void Start() {
        healthbar = GetComponent<Image>();
        health = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
        Healthbar.fillAmount = health / maxHealth;
	}
}
