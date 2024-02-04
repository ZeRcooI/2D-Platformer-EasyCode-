using UnityEngine;
using UnityEngine.SceneManagement;

public class Attacking : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Выключаем объект
            collision.gameObject.SetActive(false);

            // Перезагружаем текущую сцену
            Invoke(nameof(ReloadScene), 1f);
        }
    }

    private void ReloadScene()
    {
        // Получаем индекс текущей сцены
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Перезагружаем текущую сцену
        SceneManager.LoadScene(currentSceneIndex);

        // Получаем объект Player по тегу
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        // Если объект Player найден
        if (player != null)
        {
            // Включаем объект Player
            player.SetActive(true);
        }
    }
}
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Player"))
    //    {
    //        Destroy(collision.gameObject);

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

//private void OnTriggerEnter2D(Collider2D collision)
//{
//    if (collision.CompareTag("Player"))
//    {
//        // Выключаем объект
//        collision.gameObject.SetActive(false);

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

//    // Получаем объект Player по тегу
//    GameObject player = GameObject.FindGameObjectWithTag("Player");

//    // Если объект Player найден
//    if (player != null)
//    {
//        // Включаем объект Player
//        player.SetActive(true);
//    }
//}
