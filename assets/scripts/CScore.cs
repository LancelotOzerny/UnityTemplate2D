using TMPro;
using UnityEngine;

public class CScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    private int score = 0;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        text.text = score.ToString();
    }

    public void Add(int value)
    {
        score += value;
        text.text = score.ToString();
    }

    public void Decrement()
    {
        score--;
        text.text = score.ToString();
    }

    public void Increment()
    {
        score++;
        text.text = score.ToString();
    }
}
