using UnityEngine;
using System.Collections;

public class rayopiquete : MonoBehaviour {

    public GameObject piqueteros;
    public GameObject moyanojr;
    public GameObject facumoyano;
    public GameObject bloquecgt;

    public void piquetes() {
        Instantiate(piqueteros, piqueteros.transform.position, piqueteros.transform.rotation);
    }
    public void facu()
    {
        Instantiate(facumoyano, facumoyano.transform.position, facumoyano.transform.rotation);
    }
    public void jr()
    {
        Instantiate(moyanojr, moyanojr.transform.position, moyanojr.transform.rotation);
    }
    public void bloque()
    {
        Instantiate(bloquecgt, bloquecgt.transform.position, bloquecgt.transform.rotation);
    }
}
