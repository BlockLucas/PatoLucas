using UnityEngine;
using System.Collections;

public class bloquecgt : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-12, GetComponent<Rigidbody2D>().velocity.y);
        transform.Rotate(0, 0, -40);

    }
	
	// Update is called once per frame
	void Update () {

       
    }
}
