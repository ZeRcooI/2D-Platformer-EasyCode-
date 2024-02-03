using UnityEngine;
using UnityEngine.SceneManagement;

public class Attacking : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);

            ReloadScene();
        }
    }

    private void ReloadScene()
    {
        // Получаем индекс текущей сцены
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Перезагружаем текущую сцену
        SceneManager.LoadScene(currentSceneIndex);
    }
}

//private void OnTriggerEnter2D(Collider2D collision)
//{
//    if (collision.CompareTag("Player"))
//    {
//        // Уничтожаем игрока
//        Destroy(collision.gameObject);

//        // Перезагружаем текущую сцену
//        ReloadScene();
//    }
//}

//private void ReloadScene()
//{
//    // Получаем индекс текущей сцены
//    int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

//    // Перезагружаем текущую сцену
//    SceneManager.LoadScene(currentSceneIndex);
//}
