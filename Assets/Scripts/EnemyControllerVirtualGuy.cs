using UnityEngine;

public class EnemyControllerVirtualGuy : MonoBehaviour
{
    SpriteRenderer spriteRenderer; //������� ��������� ��������

    public float speed = 2f;
    public float timer = 0; // ���������� �������, ������� ������������ ��� ������� ������� �������� � ������������ �����������.
    public float moveDuration = 5; // ����������, ������������ ������������ �������, � ������� ������� ������ ����� ��������� � ����� �����������, ������ ��� �������� �����������.
    public Vector2 direction = Vector2.right; // ����������, ������� ������ ��������� ����������� �������� �������. � ������ ������, ������ ����� ��������� ������ ��� ������.

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();  //������� ��������� ��������
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        timer = timer + Time.deltaTime; //������ ������������� �� ��������� �����.

        if (timer >= moveDuration) //�����������, ���������� �� �������� ������������ �������� � ����� �����������.
        {
            direction = direction * -1; //���� ������� �����������, �� �����������(direction) ���������� �� ���������������(��������� �� - 1).
            timer = 0; //������ ������������ �� ����, ������� ������ ������� ��� ���������� �������� � ����� �����������.

            //���� ��� ���������� ��������� SpriteRenderer, ����� �������� �������� flipX � ����������� ��������� �� �����������.
            if (spriteRenderer != null)
            {
                spriteRenderer.flipX = !spriteRenderer.flipX;
            }
        }
    }
}