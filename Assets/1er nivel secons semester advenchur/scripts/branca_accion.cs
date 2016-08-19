using UnityEngine;
using System.Collections;

public class branca_accion : MonoBehaviour {

	public float moveSpeed;
	public bool moveRight;
	public Transform wallCheck;
	public float wallCheckRadius;
	public LayerMask WhatIsWall;
	private bool hittingWall;
	public Transform  brancapuf0ubicacion ;
	public GameObject brancapuf0;
	private Animator animator;






	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		hittingWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, WhatIsWall);

	if (hittingWall) {
			moveRight = !moveRight;
		}
	
		if (moveRight) {
			transform.localScale = new Vector3 (-1f, 1f, 1f);

			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		} else  {

			transform.localScale = new Vector3 (1f, 1f, 1f);
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		}
	

	}
	void OnTriggerEnter2D (Collider2D other){
		
		if (other.tag == "ataquesmacri") {
			Instantiate (brancapuf0, brancapuf0ubicacion.position, brancapuf0ubicacion.rotation);
		}
	}

}
