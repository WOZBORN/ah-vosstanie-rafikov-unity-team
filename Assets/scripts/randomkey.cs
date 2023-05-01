using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomkey : MonoBehaviour
{
    private int fl;
    public GameObject key;
    public GameObject key2;
    public GameObject key3;
    public GameObject key4;
    public GameObject key5;
    public GameObject key6;
    public GameObject key7;
    public GameObject key8;
    public GameObject key9;
    public GameObject key10;

    private void Start()
    {
        fl = Random.Range(1, 10);

        if(fl == 1)
        {
            key.SetActive(true);
            key2.SetActive(false);
            key3.SetActive(false);
            key4.SetActive(false);
            key5.SetActive(false);
            key6.SetActive(false);
            key7.SetActive(false);
            key8.SetActive(false);
            key9.SetActive(false);
            key10.SetActive(false);
        }

        if (fl == 2)
        {
            key.SetActive(false);
            key2.SetActive(true);
            key3.SetActive(false);
            key4.SetActive(false);
            key5.SetActive(false);
            key6.SetActive(false);
            key7.SetActive(false);
            key8.SetActive(false);
            key9.SetActive(false);
            key10.SetActive(false);
        }

        if (fl == 3)
        {
            key.SetActive(false);
            key2.SetActive(false);
            key3.SetActive(true);
            key4.SetActive(false);
            key5.SetActive(false);
            key6.SetActive(false);
            key7.SetActive(false);
            key8.SetActive(false);
            key9.SetActive(false);
            key10.SetActive(false);
        }

        if (fl == 4)
        {
            key.SetActive(false);
            key2.SetActive(false);
            key3.SetActive(false);
            key4.SetActive(true);
            key5.SetActive(false);
            key6.SetActive(false);
            key7.SetActive(false);
            key8.SetActive(false);
            key9.SetActive(false);
            key10.SetActive(false);
        }

        if (fl == 5)
        {
            key.SetActive(false);
            key2.SetActive(false);
            key3.SetActive(false);
            key4.SetActive(false);
            key5.SetActive(true);
            key6.SetActive(false);
            key7.SetActive(false);
            key8.SetActive(false);
            key9.SetActive(false);
            key10.SetActive(false);
        }

        if (fl == 6)
        {
            key.SetActive(false);
            key2.SetActive(false);
            key3.SetActive(false);
            key4.SetActive(false);
            key5.SetActive(false);
            key6.SetActive(true);
            key7.SetActive(false);
            key8.SetActive(false);
            key9.SetActive(false);
            key10.SetActive(false);
        }

        if (fl == 7)
        {
            key.SetActive(false);
            key2.SetActive(false);
            key3.SetActive(false);
            key4.SetActive(false);
            key5.SetActive(false);
            key6.SetActive(false);
            key7.SetActive(true);
            key8.SetActive(false);
            key9.SetActive(false);
            key10.SetActive(false);
        }

        if (fl == 8)
        {
            key.SetActive(false);
            key2.SetActive(false);
            key3.SetActive(false);
            key4.SetActive(false);
            key5.SetActive(false);
            key6.SetActive(false);
            key7.SetActive(false);
            key8.SetActive(true);
            key9.SetActive(false);
            key10.SetActive(false);
        }

        if (fl == 9)
        {
            key.SetActive(false);
            key2.SetActive(false);
            key3.SetActive(false);
            key4.SetActive(false);
            key5.SetActive(false);
            key6.SetActive(false);
            key7.SetActive(false);
            key8.SetActive(false);
            key9.SetActive(true);
            key10.SetActive(false);
        }

        if (fl == 10)
        {
            key.SetActive(false);
            key2.SetActive(false);
            key3.SetActive(false);
            key4.SetActive(false);
            key5.SetActive(false);
            key6.SetActive(false);
            key7.SetActive(false);
            key8.SetActive(false);
            key9.SetActive(false);
            key10.SetActive(true);
        }
    }
}
