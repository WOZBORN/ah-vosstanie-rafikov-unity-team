using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fonar : MonoBehaviour
{
    public GameObject fonar1;
    public GameObject fonar2;
    public GameObject svet1;
    public GameObject svet2;
    public GameObject svet3;
    public GameObject svet4;
    public GameObject svet5;
    public GameObject svet6;
    public GameObject svet7;
    public GameObject svet8;
    public GameObject svet9;
    public GameObject svet10;
    public AudioSource zvuk22;
    public GameObject Vasy;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            fonar1.SetActive(false);
            fonar2.SetActive(true);
            svet1.SetActive(false);
            svet2.SetActive(false);
            svet3.SetActive(false);
            svet4.SetActive(false);
            svet5.SetActive(false);
            svet6.SetActive(false);
            svet7.SetActive(false);
            svet8.SetActive(false);
            svet9.SetActive(false);
            svet10.SetActive(false);
            zvuk22.Play();
            Vasy.SetActive(true);

        }
    }
}
