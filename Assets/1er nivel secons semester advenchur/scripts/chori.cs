using UnityEngine;
using System.Collections;

public class chori : MonoBehaviour {

	public LevelManager levelManager ;
	public float speed;
	public GameObject puf;


	// Use this for initialization
	void Start () {
		levelManager = FindObjectOfType<LevelManager> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		GetComponent<Rigidbody2D> ().velocity = new Vector2 (-speed, GetComponent<Rigidbody2D> ().velocity.y);
	
	}
	void  OnTriggerEnter2D (Collider2D other)
	{
		if (other.name == "macri"){
			levelManager.RespawnPlayer();
		}
		if (other.tag == "ataquesmacri"){
			Instantiate(puf,transform.position,transform.rotation);
		}

		Destroy (gameObject);
	}
}
