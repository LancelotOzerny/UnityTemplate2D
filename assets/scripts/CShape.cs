using UnityEngine;

public class CShape : MonoBehaviour
{
    private static int ShapeCount = 3;
    [SerializeField] private CScore score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("shape"))
        {
            score.Increment();

            Destroy(collision.gameObject);
        }
    }
}
