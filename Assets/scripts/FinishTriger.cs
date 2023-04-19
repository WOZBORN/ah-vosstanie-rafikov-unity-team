using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTriger : MonoBehaviour
{
    public GameObject anim;
    public GameObject Triger;
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
           
           
            anim.SetActive(true);
            Triger.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;

        }
    }
}
