using System.Collections.Generic;
using UnityEngine;

public class HorizontalSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> prefs = new List<GameObject>();
    private static System.Random Random = new System.Random();

    [SerializeField] private float timerTime = 1.0f;
    private float time = 0.0f;

    [SerializeField] private float sidePaddings = 50;

    private Rect rect;

    private void Start()
    {
        time = timerTime;
        rect = GetComponent<RectTransform>().rect;
    }

    private void Update()
    {
        time -= Time.deltaTime;

        if (time <= 0)
        {
            time = timerTime;
            Generate();
        }
    }

    public void Generate()
    {
        GameObject prefab = prefs[Random.Next(0, prefs.Count)];
        GameObject newObj = Instantiate(prefab, transform);

        RectTransform currentRect = newObj.GetComponent<RectTransform>();
        currentRect.localPosition = new Vector2(GetPositionX(), currentRect.localPosition.y);

        Destroy(newObj, 3.0f);
    }

    private float GetPositionX()
    {
        float width = rect.size.x - sidePaddings * 2;
        float posX = Random.Next(0, ((int)width * 100)) / 100;
        float result = posX - width / 2;
        return result;
    }
}
