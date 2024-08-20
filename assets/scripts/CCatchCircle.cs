using UnityEngine;

public class CCatchCircle : MonoBehaviour
{
    private static int shapeCount = 3;
    [SerializeField] private CScore score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("shape"))
        {
            score.Add(shapeCount);
            Destroy(collision.gameObject);
        }
    }
}
