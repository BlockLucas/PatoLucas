using UnityEngine;
using System.Collections;

public class globoProcontrol : MonoBehaviour {

	public float speed;
	public macricontrol macri ;




	// Use this for initialization
	void Start () {

		macri = FindObjectOfType <macricontrol>();
		if (macri.transform.localScale.x < 0) {
			speed = -speed;
			transform.localScale = new Vector3 (-1f, 1f, 1f);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y);
	}
	void OnTriggerEnter2D (Collider2D other){

		if (other.tag == "branca0") {
			Destroy (other.gameObject);
			}
		if (other.tag == "navarro") {
			Destroy (other.gameObject);
		}
		if (other.tag == "chori") {
			Destroy (other.gameObject);
		}


		if (other.tag != "trigger") {
			Destroy (gameObject);
		}
	}
}
