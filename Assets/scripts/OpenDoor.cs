using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject Anim;
    public GameObject door;
    [SerializeField] Animation animm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Anim.SetActive(false);
            animm.Play();
        }
    }
}
