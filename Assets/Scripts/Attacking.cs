using UnityEngine;
using UnityEngine.SceneManagement;

public class Attacking : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // ��������� ������
            collision.gameObject.SetActive(false);

            // ������������� ������� �����
            Invoke(nameof(ReloadScene), 1f);
        }
    }

    private void ReloadScene()
    {
        // �������� ������ ������� �����
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // ������������� ������� �����
        SceneManager.LoadScene(currentSceneIndex);

        // �������� ������ Player �� ����
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        // ���� ������ Player ������
        if (player != null)
        {
            // �������� ������ Player
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
    //    // �������� ������ ������� �����
    //    int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

    //    // ������������� ������� �����
    //    SceneManager.LoadScene(currentSceneIndex);
    //}

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

//private void OnTriggerEnter2D(Collider2D collision)
//{
//    if (collision.CompareTag("Player"))
//    {
//        // ��������� ������
//        collision.gameObject.SetActive(false);

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

//    // �������� ������ Player �� ����
//    GameObject player = GameObject.FindGameObjectWithTag("Player");

//    // ���� ������ Player ������
//    if (player != null)
//    {
//        // �������� ������ Player
//        player.SetActive(true);
//    }
//}
