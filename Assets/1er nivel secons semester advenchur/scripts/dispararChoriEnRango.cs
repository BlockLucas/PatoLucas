using UnityEngine;
using System.Collections;

public class dispararChoriEnRango : MonoBehaviour {

	public float rangoMacri;
	public GameObject chori;
	public macricontrol macri;
	public Transform puntolanzachori;
	public float tiempoEntreChoris;
	private float cuentaChoris;

	// Use this for initialization
	void Start () {
		macri = FindObjectOfType<macricontrol>();

		cuentaChoris = tiempoEntreChoris;
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawLine (new Vector3 (transform.position.x - rangoMacri, transform.position.y, transform.position.z),
		                new Vector3 (transform.position.x, transform.position.y, transform.position.z));

		cuentaChoris -= Time.deltaTime;

		if (macri.transform.position.x > transform.position.x - rangoMacri && macri.transform.position.x < transform.position.x && cuentaChoris < 0) {
			Instantiate (chori, puntolanzachori.position, puntolanzachori.rotation);
			cuentaChoris = tiempoEntreChoris;
		}

	}
}
