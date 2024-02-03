using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float jumpforce = 8f;

    Rigidbody2D rigidbody2d;
    public Animator animator;
    public SpriteRenderer sprite;

    [SerializeField] private GameObject _restartButton;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Объединенное условие для проверки нажатия клавиши A или D
        bool isMoving = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D);

        // Установка анимации в зависимости от того, идет ли игрок влево или вправо
        animator.SetBool("isRuning", isMoving);

        // Перемещение игрока влево или вправо
        if (isMoving)
        {
            if (Input.GetKey(KeyCode.A))
            {
                sprite.flipX = true;
                transform.Translate(speed * Time.deltaTime * Vector2.left);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                sprite.flipX = false;
                transform.Translate(speed * Time.deltaTime * Vector2.right);
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
            rigidbody2d.velocity = new Vector2(rigidbody2d.velocity.x, jumpforce);
        }
    }

    private void OnDestroy()
    {
        if (_restartButton != null)
        {
            _restartButton.SetActive(true);
        }
    }
}