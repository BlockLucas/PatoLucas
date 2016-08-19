using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckpoint;
	private macricontrol macri;
	public Fade fade;


	// Use this for initialization
	void Start () {
	macri = FindObjectOfType<macricontrol>();
	fade = FindObjectOfType<Fade>();
	}
	
	// Update is called once per frame			
	void Update () {
	
	}
	public void RespawnPlayer () {
		Debug.Log ("Player Respawn");
		macri.transform.position = currentCheckpoint.transform.position;
		fade.StartScene();
   }
}