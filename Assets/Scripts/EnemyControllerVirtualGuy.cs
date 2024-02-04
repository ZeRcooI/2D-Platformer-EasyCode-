using UnityEngine;

public class EnemyControllerVirtualGuy : MonoBehaviour
{
    SpriteRenderer spriteRenderer; //������� ��������� ��������

    [SerializeField] private float _speed = 2f;
    [SerializeField] private float _timer = 0; // ���������� �������, ������� ������������ ��� ������� ������� �������� � ������������ �����������.
    [SerializeField] private float _moveDuration = 5; // ����������, ������������ ������������ �������, � ������� ������� ������ ����� ��������� � ����� �����������, ������ ��� �������� �����������.
    [SerializeField] private Vector2 _direction = Vector2.right; // ����������, ������� ������ ��������� ����������� �������� �������. � ������ ������, ������ ����� ��������� ������ ��� ������.

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();  //������� ��������� ��������
    }

    void Update()
    {
        transform.Translate(_direction * _speed * Time.deltaTime);

        _timer = _timer + Time.deltaTime; //������ ������������� �� ��������� �����.

        if (_timer >= _moveDuration) //�����������, ���������� �� �������� ������������ �������� � ����� �����������.
        {
            _direction = _direction * -1; //���� ������� �����������, �� �����������(direction) ���������� �� ���������������(��������� �� - 1).
            _timer = 0; //������ ������������ �� ����, ������� ������ ������� ��� ���������� �������� � ����� �����������.

            //���� ��� ���������� ��������� SpriteRenderer, ����� �������� �������� flipX � ����������� ��������� �� �����������.
            if (spriteRenderer != null)
            {
                spriteRenderer.flipX = !spriteRenderer.flipX;
            }
        }
    }
}