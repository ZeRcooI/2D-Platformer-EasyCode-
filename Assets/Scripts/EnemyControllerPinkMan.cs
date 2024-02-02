using UnityEngine;

public class EnemyControllerPinkMan : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private Animator _animator;

    private bool _canMove = false;
    private float _timer = 0f;

    private void Start()
    {
        _animator = GetComponent<Animator>();

        _animator.Play("Idle"); // ��������� �������� Idle ����� ��� ������
    }

    private void Update()
    {
        _timer += Time.deltaTime;

        // ��������, ������ �� ��� 3 �������
        if (_canMove)
        {
            MoveEnemy();
        }
        else if (_timer >= 3f)
        {
            _canMove = true;
            _animator.Play("Run");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // �������� �� ����� �� ����������
        if (collision.CompareTag("patrulBox"))
        {
            FlipDirection();
        }
    }

    private void MoveEnemy()
    {
        // ����������� ����� � ��������� �����
        transform.Translate(_speed * Time.deltaTime * Vector3.right);
    }

    private void FlipDirection()
    {
        var currentRotation = transform.rotation; // �������� ������� ���������� �������
        currentRotation *= Quaternion.Euler(0, 180, 0); // ������� �� 180 �������� ������ ������������ ��� Y
        transform.rotation = currentRotation; // ��������� ����� ���������� � �������
    }
}
