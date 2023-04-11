using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopaBethitThaToboy : MonoBehaviour
{
    public GameObject Popa;
    public Animation TimofeyAnimCirpitchZavod;
    public GameObject CubeRubic;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Popa.SetActive(true);
            TimofeyAnimCirpitchZavod.Play();
            CubeRubic.SetActive(false);
            
        }
    }
}
