using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame() //���� ����� ��������� ���������� ����������. �������� ��������, ��� � ������ ��������� Unity ��� � ���-������, ��� ������� ����� �� ��������. 
    {
        Application.Quit(); //�����, ������� ������������ ��� ���������� ���������� ����������. ����� ���� ����� ����������, ���������� �����������, � ���� �����������.
    }
}
