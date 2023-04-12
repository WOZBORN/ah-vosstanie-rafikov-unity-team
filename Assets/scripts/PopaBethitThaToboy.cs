using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopaBethitThaToboy : MonoBehaviour
{
    public GameObject Popa;
    public AudioSource TimoshaNaloJilVStana;
    public GameObject CubeRubic;
    public GameObject Fonar1;
    public GameObject Fonar2;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Popa.SetActive(true);
            TimoshaNaloJilVStana.Play();
            CubeRubic.SetActive(false);
            Fonar1.SetActive(false);
            Fonar2.SetActive(true);
        }
    }
}
