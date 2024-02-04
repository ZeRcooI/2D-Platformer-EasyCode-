using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            Invoke(nameof(LoadNextScene), 1f); // �������� � 1 ������� ����� ��������� ��������� �����
        }
    }

    private void LoadNextScene()
    {
        // ��������� ��������� �����. ��������������, ��� � ��� ���� ����� � ����� Unity � ����������� Build Index.
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        SceneManager.LoadScene(nextSceneIndex);
    }
}
