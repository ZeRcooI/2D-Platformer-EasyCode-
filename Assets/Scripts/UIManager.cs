using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }

}