using UnityEngine;
using System.Collections;

public class proxnivel : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "macri")
			Application.LoadLevel(2);
	}


}
