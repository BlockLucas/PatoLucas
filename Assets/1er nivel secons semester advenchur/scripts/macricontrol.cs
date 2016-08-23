using UnityEngine;
using System.Collections;

public class macricontrol : MonoBehaviour {
	public float xOffset;
	public float yOffset;
	public float zOffset;
	public float moveSpeed;
	private float moveVelocity;
	public float jumpHeight;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask WhatIsGround;
	private bool grounded;
	private bool doubleJumped;
	private Animator animator;
	public Transform varita;
	public GameObject globoPro;

	void Awake () {
		animator = GetComponent<Animator>();  
	}

	// Use this for initialization
	void Start () {
	
	}
	void FixedUpdate () {
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, WhatIsGround);
		
	}
	
	// Update is called once per frame
	void Update () {

	
		if (grounded)
			doubleJumped = false;



		if (Input.GetKeyDown (KeyCode.D) && grounded ){
			animator.SetInteger ("AnimState",2);
			GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, jumpHeight);

	
		}

	    if (Input.GetKeyDown (KeyCode.D) && !doubleJumped && !grounded ){
			GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
		    doubleJumped = true;

		}

		moveVelocity = 0f;


	    if (Input.GetKey (KeyCode.LeftArrow)){
			//GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = -moveSpeed;
			transform.localScale = new Vector3 (-1f, 1f, 1f);{
				if (!grounded)
					animator.SetInteger ("AnimState",2);
				if (grounded)
					animator.SetInteger ("AnimState",1);
			}
		}
	    else if (Input.GetKey (KeyCode.RightArrow)) {
			//GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
			moveVelocity = moveSpeed;
			transform.localScale = new Vector3 (1f, 1f, 1f);{

				if (!grounded)
				    animator.SetInteger ("AnimState",2);
			    if (grounded)
					animator.SetInteger ("AnimState",1);
			}
			
		}

		else {
			animator.SetInteger ("AnimState",0);
		}

		GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveVelocity, GetComponent<Rigidbody2D> ().velocity.y);

		if (Input.GetKeyDown (KeyCode.S)){
			animator.SetInteger ("AnimState",3);
			Instantiate (globoPro, varita.position,varita.rotation );

		}
		if (!grounded)
			animator.SetInteger ("AnimState",2); 
		if (Input.GetKey (KeyCode.S)){
			animator.SetInteger ("AnimState",3);
			
		}

		// fix camera
		float x = transform.position.x;
		Camera.main.transform.position = new Vector3 (transform.position.x + xOffset, transform.position.y + yOffset, transform.position.z + zOffset);

	}
}
