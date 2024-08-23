using UnityEngine;

public class DesktopControl : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 2.0f;

    private void Awake()
    {
        if (Application.isMobilePlatform)
        {
            Destroy(this);
        }
    }

    void Update()
    {
        if (Tools.Instance.isPause == false)
        {
            Vector3 direction = new Vector3(0, 0, -Input.GetAxisRaw("Horizontal"));
            float angle = rotateSpeed * Time.deltaTime;

            transform.Rotate(direction, angle);
        }
    }
}