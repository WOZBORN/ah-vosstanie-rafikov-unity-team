using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayAgain : MonoBehaviour
{
    public void restartClicer()
    {
        SceneManager.LoadScene(0);
    }
}
