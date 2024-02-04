using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            Invoke(nameof(LoadNextScene), 1f); // Задержка в 1 секунду перед загрузкой следующей сцены
        }
    }

    private void LoadNextScene()
    {
        // Загружаем следующую сцену. Предполагается, что у вас есть сцены в билде Unity с настройками Build Index.
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        SceneManager.LoadScene(nextSceneIndex);
    }
}
