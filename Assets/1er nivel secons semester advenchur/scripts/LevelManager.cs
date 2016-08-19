using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckpoint;
	private macricontrol macri;


	// Use this for initialization
	void Start () {
	macri = FindObjectOfType<macricontrol>();
	
	}
	
	// Update is called once per frame			
	void Update () {
	
	}
	public void RespawnPlayer () {
		Debug.Log ("Player Respawn");
		macri.transform.position = currentCheckpoint.transform.position;

   }
}