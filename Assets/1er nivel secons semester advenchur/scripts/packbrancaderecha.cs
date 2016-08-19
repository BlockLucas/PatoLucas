using UnityEngine;
using System.Collections;

public class packbrancaderecha : MonoBehaviour {

	public float speed;
	public GameObject brancapuf0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y);
	
	}
	void OnTriggerEnter2D (Collider2D other){
		
		if (other.tag == "ataquesmacri") {
			Instantiate (brancapuf0, transform.position, transform.rotation);
		}
	}
}
