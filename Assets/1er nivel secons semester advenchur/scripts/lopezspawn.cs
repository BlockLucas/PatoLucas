﻿using UnityEngine;
using System.Collections;

public class lopezspawn : MonoBehaviour {

	public Transform lopezpunto;
	public GameObject lopez;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D (Collider2D other){
		if (other.name == "macri") {
			Debug.Log ("se instancio");
			Instantiate (lopez,lopezpunto.position,lopezpunto.rotation);
		}
		Destroy (gameObject);
	}

}
