using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    [SerializeField] private float _jumpforce = 8f;

    private Rigidbody2D rigidbody2d;
    [SerializeField] private Animator _animator;
    [SerializeField] private SpriteRenderer _sprite;

    [SerializeField] private GameObject _restartButton;

    private void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Объединенное условие для проверки нажатия клавиши A или D
        bool isMoving = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D);

        // Установка анимации в зависимости от того, идет ли игрок влево или вправо
        _animator.SetBool("isRuning", isMoving);

        // Перемещение игрока влево или вправо
        if (isMoving)
        {
            if (Input.GetKey(KeyCode.A))
            {
                _sprite.flipX = true;
                transform.Translate(_speed * Time.deltaTime * Vector2.left);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                _sprite.flipX = false;
                transform.Translate(_speed * Time.deltaTime * Vector2.right);
            }
        }

        //transform.Translate используется для перемещения объекта в пространстве по указанному вектору.
        //Vector2.left - это вектор, указывающий влево(отрицательное направление по оси X).

        //Time.deltaTime - это значение, представляющее время, прошедшее с момента последнего кадра.
        //Использование Time.deltaTime обеспечивает плавное движение объекта независимо от фреймрейта игры.

        //Условие для перехода в бег
        //if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        //{
        //    animator.SetBool("isRuning", true);
        //}
        //else
        //{
        //    animator.SetBool("isRuning", false);
        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(speed * Time.deltaTime * Vector2.left);
        //}
        //else if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(speed * Time.deltaTime * Vector2.right);
        //}

        //GetKeyDown - это метод, который можно использовать для определения, была ли нажата клавиша на клавиатуре в данный момент времени.
        //можем настроить гравитацию для нормального прыжка
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2d.velocity = new Vector2(rigidbody2d.velocity.x, _jumpforce);
        }
    }

    //private void OnDestroy()
    //{
    //    if (_restartButton != null)
    //    {
    //        _restartButton.SetActive(true);
    //    }
    //}
    private void OnDisable()
    {
        if (_restartButton != null)
        {
            _restartButton.SetActive(true);
        }
    }
}