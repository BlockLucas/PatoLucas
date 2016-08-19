using UnityEngine;
using System.Collections;

public class piqueterosPosicion : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-9, GetComponent<Rigidbody2D>().velocity.y);



    }
}
