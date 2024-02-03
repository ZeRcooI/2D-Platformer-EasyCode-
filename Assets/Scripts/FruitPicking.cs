using TMPro;
using UnityEngine;
using UnityEngine.UI; //подключаем канвас

public class FruitPicking: MonoBehaviour
{
    private int _score = 0;
    [SerializeField] private TextMeshProUGUI _textMeshPro;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("fruits"))
        {
            _score += 1;

            _textMeshPro.text = _score.ToString(); // связываем и конвертим очки в стринг

            Destroy(collision.gameObject);
        }
    }
}
