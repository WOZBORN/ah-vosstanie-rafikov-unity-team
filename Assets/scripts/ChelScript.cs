using UnityEngine;
using UnityEngine.AI;

public class ChelScript : MonoBehaviour
{
    public Animation sceletAnim;

    public GameObject scelet;
    public GameObject skrimer;
    public GameObject sceletVVanne;
    public GameObject KeySceleta;
    public GameObject KeyIgroka;

    private bool sceletkluch;
    private bool IceScream;

    public float timer1;
    public float timer2;
    private void Awake()
    {
        sceletkluch = true;
        IceScream = false;
    }
    private void Update()
    {
        if (sceletkluch == false)
        {
            sceletAnim.Play();
            sceletVVanne.SetActive(false);
            if (timer2 > 0)
            {
                timer2 -= Time.deltaTime;
            }
            if (timer2 <= 0)
            {
                scelet.SetActive(true);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        { 
            KeySceleta.SetActive(false);
            KeyIgroka.SetActive(true);
            sceletkluch = false;
        }
    }
}