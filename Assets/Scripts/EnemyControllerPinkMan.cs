using UnityEngine;

public class EnemyControllerPinkMan : MonoBehaviour
{
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;
    private bool _isFacingRight = true;

    [SerializeField] private float _raycastLenghts = 1.2f;
    [SerializeField] private Vector2 _offset;

    private float _speed = 2f;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();

        PlayIdleAnimation(); // ��������� �������� Idle ����� ��� ������
        InvokeRepeating(nameof(CheckForPlatformAndFlip), 0f, 2f); // ��������� �������� � ��������� �����������
    }

    private void PlayIdleAnimation()
    {
        // ������ �������� Idle
        _animator.Play("EnemyPinkMan Idle");
        //_animator.SetTrigger("EnemyPinkMan Idle");
    }

    private void CheckForPlatformAndFlip()
    {
        // �������� ������� ��������� ����� ���������
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down + _offset, _raycastLenghts, LayerMask.GetMask("Ground"));

        if (hit.collider == null)
        {
            // ���� ��� ���������, ������ ������ ����������� ����� flip
            Flip();
        }
    }

    private void Flip()
    {
        // ������������� �����������
        _isFacingRight = !_isFacingRight;
        // �������� ����������� ������� ����� flip
        _spriteRenderer.flipX = !_spriteRenderer.flipX;
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, Vector3.right * _speed, Time.deltaTime);
    }
}
