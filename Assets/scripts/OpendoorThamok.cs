using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpendoorThamok : MonoBehaviour
{
    public GameObject Anim;
    public GameObject door;
    public GameObject keey;
    [SerializeField] Animation animm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("key"))
        {
            keey.SetActive(false);
            Anim.SetActive(false);
            animm.Play();
        }
    }
}
