using UnityEngine;
using System.Collections;

public class globoPro2 : MonoBehaviour {
	public float velocidad;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		GetComponent<Rigidbody2D> ().velocity = new Vector2 (velocidad, GetComponent<Rigidbody2D> ().velocity.y);
	
	}
}
