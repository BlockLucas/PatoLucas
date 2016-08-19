using UnityEngine;
using System.Collections;

public class maurinivel2 : MonoBehaviour {

	private Animator animator;
	public Transform puntoataques;
	public GameObject globoPro2;



	void Awake () {
		animator = GetComponent<Animator>();  
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.S)) {
			animator.SetInteger ("mauri", 1);
			Instantiate (globoPro2, puntoataques.position,puntoataques.rotation );
		} else {
			animator.SetInteger ("mauri", 0);
		}
		if (Input.GetKey (KeyCode.S)) {
			animator.SetInteger ("mauri", 1);
		}

	
	}
}
