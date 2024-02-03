using TMPro;
using UnityEngine;
using UnityEngine.UI; //подключаем канвас

public class FruitPicking: MonoBehaviour
{
    [SerializeField] private int _score;
    [SerializeField] private TextMeshProUGUI _textMeshPro;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

        if (collision.CompareTag("fruits"))
        {
            _score += 1;

            Destroy(collision.gameObject);

            _textMeshPro.text = _score.ToString(); // связываем и конвертим очки в стринг
        }
    }
}
