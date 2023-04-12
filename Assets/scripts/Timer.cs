using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public GameObject Object;
    public float timer1;
   
    void Update()
    {
        if(timer1>0)
        {
            timer1 -= Time.deltaTime;
        }
        if(timer1<=0)
        {
            Object.SetActive(false);
        }
    }
}
