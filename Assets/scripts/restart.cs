using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public void Restart()
    {
        Debug.Log("button clicked");
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
