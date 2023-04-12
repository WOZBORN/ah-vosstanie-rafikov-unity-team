using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopaScrinic : MonoBehaviour
{
    public GameObject Popa;
    public GameObject AndreiObosris;
    public AudioSource Thvuk;
    public GameObject Fonar1;
    public GameObject Fonar2;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            Popa.SetActive(false);
            AndreiObosris.SetActive(true);
            Thvuk.Play();
            Fonar1.SetActive(true);
            Fonar2.SetActive(false);
        }
    }
}
