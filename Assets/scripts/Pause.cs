

using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pause;

    void Update()
    {

        if (Input.GetKey(KeyCode.Escape))
        {
            pause.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }

    }

    public void resume()
    {
        pause.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
    }    


}
