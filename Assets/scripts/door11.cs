using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door11 : MonoBehaviour
{
    public GameObject keey;
    public GameObject keey2;
    public GameObject door;
    [SerializeField] Animation animm;
    public GameObject anim;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("key"))
        {
            keey.SetActive(false);
            keey2.SetActive(true);
            anim.SetActive(false);
            animm.Play();
        }
    }
}
