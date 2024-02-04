using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitGame() //���� ����� ��������� ���������� ����������. �������� ��������, ��� � ������ ��������� Unity ��� � ���-������, ��� ������� ����� �� ��������. 
    {
        Application.Quit(); //�����, ������� ������������ ��� ���������� ���������� ����������. ����� ���� ����� ����������, ���������� �����������, � ���� �����������.
    }
}
