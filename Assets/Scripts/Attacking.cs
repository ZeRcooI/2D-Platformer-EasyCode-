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
        // �������� ������ ������� �����
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // ������������� ������� �����
        SceneManager.LoadScene(currentSceneIndex);
    }
}

//private void OnTriggerEnter2D(Collider2D collision)
//{
//    if (collision.CompareTag("Player"))
//    {
//        // ���������� ������
//        Destroy(collision.gameObject);

//        // ������������� ������� �����
//        ReloadScene();
//    }
//}

//private void ReloadScene()
//{
//    // �������� ������ ������� �����
//    int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

//    // ������������� ������� �����
//    SceneManager.LoadScene(currentSceneIndex);
//}
