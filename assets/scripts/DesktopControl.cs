using UnityEngine;

public class DesktopControl : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 2.0f;

    void Update()
    {
        Vector3 direction = new Vector3(0, 0, -Input.GetAxisRaw("Horizontal"));
        float angle = rotateSpeed * Time.deltaTime;

        transform.Rotate(direction, angle);
    }
}
