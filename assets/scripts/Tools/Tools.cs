using UnityEngine;

public class Tools : MonoBehaviour
{
    [HideInInspector] public bool isPause = false;

    private static Tools instance = null;

    public void SetPause(bool value)
    {
        this.isPause = value;
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
            return;
        }

        instance = this;
    }

    public static Tools Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject obj = Instantiate(new GameObject());
                instance = obj.AddComponent<Tools>();
            }


            return instance;
        }
    }
}