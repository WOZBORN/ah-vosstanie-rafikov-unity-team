using UnityEngine;

public class ChelScript : MonoBehaviour
{
    public Animation sceletAnim;

    public AudioSource sceletPoyavlyaetsya;

    public GameObject scelet;
    public GameObject sceletVVanne;
    public GameObject KeySceleta;
    public GameObject KeyIgroka;

    public bool sceletkluch;

    public float timer2;
    private void Awake()
    {
        sceletkluch = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            KeySceleta.SetActive(false);
            KeyIgroka.SetActive(true);
            sceletkluch = false;
        }
        if (sceletkluch == false)
        {
            sceletAnim.Play();
            sceletVVanne.SetActive(false);
            sceletPoyavlyaetsya.Play();
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
}