using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame() //Этот метод завершает выполнение приложения. Обращаем внимание, что в режиме редактора Unity или в веб-плеере, эта команда может не работать. 
    {
        Application.Quit(); //метод, который используется для завершения выполнения приложения. Когда этот метод вызывается, приложение завершается, и игра закрывается.
    }
}
