using UnityEngine;

public class EnemyControllerVirtualGuy : MonoBehaviour
{
    SpriteRenderer spriteRenderer; //создаем компонент поворота

    [SerializeField] private float _speed = 2f;
    [SerializeField] private float _timer = 0; // переменна€ таймера, котора€ используетс€ дл€ отсчета времени движени€ в определенном направлении.
    [SerializeField] private float _moveDuration = 5; // переменна€, определ€юща€ длительность времени, в течение которой объект будет двигатьс€ в одном направлении, прежде чем изменить направление.
    [SerializeField] private Vector2 _direction = Vector2.right; // переменна€, котора€ задает начальное направление движени€ объекта. ¬ данном случае, объект будет двигатьс€ вправо при старте.

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();  //находим компонент поворота
    }

    void Update()
    {
        transform.Translate(_direction * _speed * Time.deltaTime);

        _timer = _timer + Time.deltaTime; //“аймер увеличиваетс€ на прошедшее врем€.

        if (_timer >= _moveDuration) //ѕровер€етс€, достигнута ли заданна€ длительность движени€ в одном направлении.
        {
            _direction = _direction * -1; //≈сли условие выполн€етс€, то направление(direction) измен€етс€ на противоположное(умножение на - 1).
            _timer = 0; //“аймер сбрасываетс€ до нул€, начина€ отсчет времени дл€ следующего движени€ в новом направлении.

            //Ётот код использует компонент SpriteRenderer, чтобы изменить свойство flipX и перевернуть персонажа по горизонтали.
            if (spriteRenderer != null)
            {
                spriteRenderer.flipX = !spriteRenderer.flipX;
            }
        }
    }
}