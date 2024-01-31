using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
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
    }
}