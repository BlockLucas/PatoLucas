using UnityEngine;
using System.Collections;

public class michettimacricontrol : MonoBehaviour {

    public float moveSpeed;
    public float salto;
	public Transform chequeoTierra;
	public float chequeoRadio;
	public LayerMask tierra;
	private bool enElSuelo;
	private Animator animator;
	public Transform puntoataques;
	public GameObject globoPro;


	void Awake () {
		animator = GetComponent<Animator>();  
	}


	// Use this for initialization
	void Start () {
	
	}
	void FixedUpdate () {
		enElSuelo = Physics2D.OverlapCircle(chequeoTierra.position, chequeoRadio, tierra);
		
	}
	
	// Update is called once per frame
	void Update () {
       


        if (Input.GetKeyDown(KeyCode.D)&& enElSuelo) {
			GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, salto);

		}


        if (Input.GetKey(KeyCode.LeftArrow) && enElSuelo)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        if (Input.GetKey(KeyCode.RightArrow) && enElSuelo)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2( moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -17.5F, -5.75F), transform.position.y);






    }
}
