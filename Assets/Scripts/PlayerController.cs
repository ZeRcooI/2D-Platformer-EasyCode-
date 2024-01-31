using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        //transform.Translate ������������ ��� ����������� ������� � ������������ �� ���������� �������.
        //Vector2.left - ��� ������, ����������� �����(������������� ����������� �� ��� X).

        //Time.deltaTime - ��� ��������, �������������� �����, ��������� � ������� ���������� �����.
        //������������� Time.deltaTime ������������ ������� �������� ������� ���������� �� ���������� ����.

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(speed * Time.deltaTime * Vector2.left);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime * Vector2.right);
        }
    }
}