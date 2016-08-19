using UnityEngine;
using System.Collections;

public class lanatamamertospawn : MonoBehaviour {

	public Transform lanatamamertopunto ;
	public GameObject lanatamamerto;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D (Collider2D other){
		
		if (other.name == "macri") {
			Instantiate (lanatamamerto, lanatamamertopunto.position, lanatamamertopunto.rotation);
			Destroy (gameObject);
		}
	}
}
