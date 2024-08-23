using UnityEngine;

public class MobileControl : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 2.0f;
    [SerializeField] private Vector3 rotate;

    void Update()
    {
        if (Tools.Instance.isPause == false)
        {
            float zDirection = Mathf.Abs(Input.acceleration.x) > 0.25f ? Input.acceleration.x : 0;

            Vector3 direction = new Vector3(0, 0, -zDirection);

            float angle = rotateSpeed * Time.deltaTime;
            transform.Rotate(direction, angle);
        }
    }
}
