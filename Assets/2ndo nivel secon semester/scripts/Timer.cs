using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{
    public GameObject piqueteros;
    public float waitTime = 3f;

    void Start()
    {
        StartCoroutine(HarmPlayer());
    }

    IEnumerator HarmPlayer()
    {
        yield return new WaitForSeconds(waitTime);
        Instantiate(piqueteros, transform.position, transform.rotation);
        yield return null;
    }
}