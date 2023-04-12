using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopaScrinic : MonoBehaviour
{
    public GameObject Popa;
    public GameObject AndreiObosris;
    public AudioSource Thvuk;
    
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            Popa.SetActive(false);
            AndreiObosris.SetActive(true);
            Thvuk.Play();
            


        }
    }
}
