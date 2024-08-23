using UnityEngine;

public class CCatchCircle : MonoBehaviour
{
    [SerializeField] private string circleType = "white";

    private static int shapeCount = 0;
    [SerializeField] private CScore score;

    [SerializeField] private int lifes = 2;

    void Awake()
    {
        CCatchCircle.shapeCount++;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("shape"))
        {
            CShape shape = collision.GetComponent<CShape>();

            if (shape.IsSuitableColor(this.circleType))
            {
                score.Add(shapeCount);
            }
            else if (--lifes == 0)
            {
                Destroy(this.gameObject);
            }

            Destroy(collision.gameObject);
        }
    }

    private void OnDestroy()
    {
        CCatchCircle.shapeCount--;
    }
}
