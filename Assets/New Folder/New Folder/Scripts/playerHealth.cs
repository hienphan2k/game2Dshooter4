using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour {

	public float maxHealth;
	float currentHealth;

	public GameObject bloodEffect;

	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void addDamage(float damage){
		if (damage <= 0)
			return;
		currentHealth -= damage;

		if (currentHealth <= 0)
			makeDead ();
	}

	void makeDead(){
		Instantiate (bloodEffect, transform.position, transform.rotation);
		Destroy (gameObject);
	}
}
