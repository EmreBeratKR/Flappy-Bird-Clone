using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private Vector2 gap;
    [SerializeField] private Vector2 distance;
    [SerializeField] private Vector2 height;
    private ValueRange gapRange;
    private ValueRange distanceRange;
    private ValueRange heightRange;


    private void Start()
    {
        gapRange = new ValueRange{min = gap.x, max = gap.y};
        distanceRange = new ValueRange{min = distance.x, max = distance.y};
        heightRange = new ValueRange{min = height.x, max = height.y};
    }

    private ObstacleGroup First()
    {
        return transform.GetChild(0).GetComponent<ObstacleGroup>();
    }

    private Transform Last()
    {
        return transform.GetChild(transform.childCount-1);
    }

    public void Pool()
    {
        ObstacleGroup first = First();

        float randomGap = Random.Range(gapRange.min, gapRange.max);
        float randomDistance = Random.Range(distanceRange.min, distanceRange.max);
        float randomHeight = Random.Range(heightRange.min, heightRange.max);

        first.top.localPosition = Vector3.up * (randomGap / 2f);
        first.top.localPosition = Vector3.up * (randomGap / 2f);

        first.transform.position = Last().position + new Vector3(randomDistance, randomHeight, 0f);

        first.transform.SetAsLastSibling();
    }

    public struct ValueRange
    {
        public float min;
        public float max;
    }
}
