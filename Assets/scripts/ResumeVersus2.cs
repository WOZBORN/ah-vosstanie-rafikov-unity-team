using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeVersus2 : MonoBehaviour
{
    public GameObject pause;

    public GameObject Triger;


    public void resume()
    {
        pause.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        
    }
}
