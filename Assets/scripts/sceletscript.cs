using UnityEngine;

public class sceletscript : MonoBehaviour
{
    public GameObject sceletbejit;
    public GameObject skrimer;

    public AudioSource pizdec;

    public float timer;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sceletbejit.SetActive(false);
            skrimer.SetActive(true);
            pizdec.Play();
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            if (timer <= 0)
            {
                skrimer.SetActive(false);
            }
        }
    }
}
