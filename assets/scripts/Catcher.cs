using UnityEngine;
using UnityEngine.Events;

public class Catcher : MonoBehaviour
{
    [SerializeField] private UnityEvent looseEvent = null;

    private static Catcher instance = null;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
            return;
        }

        instance = this;
    }

    public static Catcher Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject obj = Instantiate(new GameObject());
                instance = obj.AddComponent<Catcher>();
            }

            return instance;
        }
    }

    public void InvokeLooseEvent()
    {
        if (looseEvent != null)
        {
            looseEvent.Invoke();
        }
    }
}
