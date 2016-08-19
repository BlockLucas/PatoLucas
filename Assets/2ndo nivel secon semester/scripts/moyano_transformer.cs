using UnityEngine;
using System.Collections;

public class moyano_transformer : MonoBehaviour {
    public GameObject rayo;
    public GameObject bloquecgt;

    public void piquetes()  {
        Instantiate(rayo, rayo.transform.position, rayo.transform.rotation);
    }
    public void bloque()
    {
        Instantiate(bloquecgt, bloquecgt.transform.position, bloquecgt.transform.rotation);
    }



}
