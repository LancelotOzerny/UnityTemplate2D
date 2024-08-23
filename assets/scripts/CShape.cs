using UnityEngine;

public class CShape : MonoBehaviour
{
    protected string shapeType = "none";
    public string ShapeType { get { return shapeType.ToLower(); }}

    [SerializeField] private float failSpeed = 5f;

    public virtual bool IsSuitableColor(string color)
    {
        return color.ToLower() == this.ShapeType;
    }

    protected Vector2 CurrentPos
    {
        get => transform.position;
        set => transform.position = new Vector3(value.x, value.y, transform.position.z);
    }

    protected void Update()
    {
        if (Tools.Instance.isPause == false)
        {
            CurrentPos = new Vector3(CurrentPos.x, CurrentPos.y - failSpeed * Time.deltaTime);
        }
    }
}
