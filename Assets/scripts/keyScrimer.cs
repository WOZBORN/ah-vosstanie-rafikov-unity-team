using UnityEngine;

public class keyScrimer : MonoBehaviour
{
    public GameObject Scelet;
    public GameObject Scelet2;
    public GameObject Screamir;

    public AudioSource Zvyk;

    public GameObject Key;
    public GameObject Key2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Key.SetActive(false);
            Key2.SetActive(true);
            Scelet.SetActive(false);
            Scelet2.SetActive(true);
            Screamir.SetActive(true);
            Zvyk.Play();
        }
    }
}
