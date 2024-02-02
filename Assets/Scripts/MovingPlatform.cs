using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private Transform _startPoint;
    [SerializeField] private Transform _endPoint;
    [SerializeField] private float _speed = 3f;

    private bool _movingToEnd = true;

    private void Update()
    {
        MovePlatform();
    }

    private void MovePlatform()
    {
        // отвечает за движение платформы влево и вправо между заданными точками _startPoint и _endPoint.
        if (_movingToEnd)
        {
            transform.Translate(_speed * Time.deltaTime * Vector3.right);

            if (transform.position.x >= _endPoint.position.x)
            {
                _movingToEnd = false;
            }
        }
        else
        {
            transform.Translate(_speed * Time.deltaTime * Vector3.left);

            if (transform.position.x <= _startPoint.position.x)
            {
                _movingToEnd = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // ”ничтожение платформы при столкновении с игроком
            Destroy(gameObject);
        }
    }
}
