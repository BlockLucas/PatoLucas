using UnityEngine;
using System.Collections;

public class fabricacionbranca : MonoBehaviour {

	public Transform fabricapackbranca;
	public GameObject packbranca;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D (Collider2D other){
		if (other.name == "macri") {
			Instantiate (packbranca,fabricapackbranca.position,fabricapackbranca.rotation);
			Destroy (gameObject);
		}

	}
}
