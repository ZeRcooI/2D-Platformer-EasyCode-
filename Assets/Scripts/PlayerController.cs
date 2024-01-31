using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;

    public float speed = 10f;
    public float jumpforce = 8f; 


    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
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

        //GetKeyDown - ��� �����, ������� ����� ������������ ��� �����������, ���� �� ������ ������� �� ���������� � ������ ������ �������.
        //����� ��������� ���������� ��� ����������� ������
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2d.velocity = new Vector2(rigidbody2d.velocity.x, jumpforce);
        }
    }
}