using UnityEngine;

public class key : MonoBehaviour
{
    public GameObject Key;
    public GameObject Key2;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Key.SetActive(false);
            Key2.SetActive(true);
        }
    }
}
