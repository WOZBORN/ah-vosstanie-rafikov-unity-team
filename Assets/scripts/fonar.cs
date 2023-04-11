using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fonar : MonoBehaviour
{
    public GameObject fonar1;
    public GameObject fonar2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            fonar1.SetActive(false);
            fonar2.SetActive(true);
        }
    }
}
