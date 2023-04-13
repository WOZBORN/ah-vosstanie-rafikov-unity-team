using UnityEngine;

public class DverVSvetloeBydyucthee : MonoBehaviour
{
    public GameObject keey;
    public GameObject door;
    [SerializeField] Animation animm;
    public GameObject anim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("key"))
        {
            keey.SetActive(false);
            anim.SetActive(false);
            animm.Play();
        }
    }
}
