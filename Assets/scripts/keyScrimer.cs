using System.Collections.Generic;
using UnityEngine;

public class keyScrimer : MonoBehaviour
{
    public GameObject Scelet;
    public GameObject Scelet2;

    public float Stimer1;

    public AudioSource Zvyk;

    public GameObject Key;
    public GameObject Key2;

    public float time = 10f; // время в секундах
    public bool isLooping = false; // флаг для повтора таймера
    public List<string> commands; // список команд для выполнения

    private float timer;
    void Start()
    {
        timer = time;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Key.SetActive(false);
            Key2.SetActive(true);
            Scelet.SetActive(false);
            Scelet2.SetActive(true);
            Zvyk.Play();
            if (timer > 0f)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                ExecuteCommands();
                if (isLooping)
                {
                    timer = time;
                }
                else
                {
                    enabled = false;
                }
            }
            void ExecuteCommands()
            {
                foreach (string command in commands)
                {
                    Debug.Log("Executing command: " + command);
                    // выполнение команды
                }
            }
        }
    }
}
