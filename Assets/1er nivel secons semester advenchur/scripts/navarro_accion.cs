using UnityEngine;
using System.Collections;

public class navarro_accion : MonoBehaviour {

	public Transform  brancapuf0ubicacion ;
	public GameObject brancapuf0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {




	
	}
	void OnTriggerEnter2D (Collider2D other){
		
		if (other.tag == "ataquesmacri") {
			Instantiate (brancapuf0, brancapuf0ubicacion.position, brancapuf0ubicacion.rotation);
		}
	}
}
