using UnityEngine;

public class ChatGPTGenii : MonoBehaviour
{
    public GameObject Scelet;
    public GameObject scelet2;

    public AudioSource TimofeyObosryotsa;
    public float timer1;

    void Update()
    {
        if (timer1 > 0)
        {
            timer1 -= Time.deltaTime;
        }
        if (timer1 <= 0)
        {
            Scelet.SetActive(false);
            scelet2.SetActive(true);
            TimofeyObosryotsa.Play();
        }
    }
}
