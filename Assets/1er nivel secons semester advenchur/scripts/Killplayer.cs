using UnityEngine;
using System.Collections;

public class Killplayer : MonoBehaviour {

	public Fade fade;

	public LevelManager levelManager ;

	// Use this for initialization
	void Start () {
		fade = FindObjectOfType<Fade> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void  OnTriggerEnter2D (Collider2D other)
	{
		if (other.name == "macri"){
			fade.EndScene ();
		}
	}

}