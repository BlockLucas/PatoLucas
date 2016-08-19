using UnityEngine;
using System.Collections;

public class valija : MonoBehaviour {

	public GameObject puf;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, GetComponent<Rigidbody2D> ().velocity.y);
	}
	void OnTriggerEnter2D (Collider2D other){

		if (other.tag == "ataquesmacri"){
			Instantiate(puf,transform.position,transform.rotation);
		}
		Destroy (gameObject);

	
	}
}
