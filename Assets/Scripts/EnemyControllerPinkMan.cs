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

        _animator.Play("Idle"); // Запустить анимацию Idle сразу при старте
    }

    private void Update()
    {
        _timer += Time.deltaTime;

        // Проверка, прошло ли уже 3 секунды
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
        // Проверка на выход из коллайдера
        if (collision.CompareTag("patrulBox"))
        {
            FlipDirection();
        }
    }

    private void MoveEnemy()
    {
        // Перемещение врага к следующей точке
        transform.Translate(_speed * Time.deltaTime * Vector3.right);
    }

    private void FlipDirection()
    {
        var currentRotation = transform.rotation; // Получаем текущую ориентацию объекта
        currentRotation *= Quaternion.Euler(0, 180, 0); // Поворот на 180 градусов вокруг вертикальной оси Y
        transform.rotation = currentRotation; // Применяем новую ориентацию к объекту
    }
}
