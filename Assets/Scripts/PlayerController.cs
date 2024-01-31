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
        //transform.Translate используетс€ дл€ перемещени€ объекта в пространстве по указанному вектору.
        //Vector2.left - это вектор, указывающий влево(отрицательное направление по оси X).

        //Time.deltaTime - это значение, представл€ющее врем€, прошедшее с момента последнего кадра.
        //»спользование Time.deltaTime обеспечивает плавное движение объекта независимо от фреймрейта игры.

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(speed * Time.deltaTime * Vector2.left);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime * Vector2.right);
        }

        //GetKeyDown - это метод, который можно использовать дл€ определени€, была ли нажата клавиша на клавиатуре в данный момент времени.
        //можем настроить гравитацию дл€ нормального прыжка
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2d.velocity = new Vector2(rigidbody2d.velocity.x, jumpforce);
        }
    }
}