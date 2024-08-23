using UnityEngine;

public class CShape : MonoBehaviour
{
    [SerializeField] private string shapeType = "white";
    public string ShapeType { get { return shapeType; }}

    [SerializeField] private float failSpeed = 5f;

    protected Vector2 CurrentPos
    {
        get => transform.position;
        set => transform.position = new Vector3(value.x, value.y, transform.position.z);
    }

    private void Update()
    {
        CurrentPos = new Vector3(CurrentPos.x, CurrentPos.y - failSpeed * Time.deltaTime);
    }
}
