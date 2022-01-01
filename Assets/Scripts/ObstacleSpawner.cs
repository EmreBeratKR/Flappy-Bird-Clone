using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private ObstacleGroup borders;
    [SerializeField] private ValueRange gapRange;
    [SerializeField] private ValueRange distanceRange;
    [SerializeField] private ValueRange heightRange;


    private ObstacleGroup First()
    {
        return transform.GetChild(0).GetComponent<ObstacleGroup>();
    }

    private Transform Last()
    {
        return transform.GetChild(transform.childCount-1);
    }

    private void CheckBorders(ObstacleGroup group)
    {
        float deltaTop = borders.top.position.y - group.top.position.y;
        float deltaBottom = group.bottom.position.y - borders.bottom.position.y;
        if (deltaTop < 0)
        {
            group.transform.position += Vector3.down * Mathf.Abs(deltaTop);
        }

        if (deltaBottom < 0)
        {
            group.transform.position += Vector3.up * Mathf.Abs(deltaBottom);
        }
    }

    public void Pool()
    {
        ObstacleGroup first = First();

        float randomGap = Random.Range(gapRange.min, gapRange.max);
        float randomDistance = Random.Range(distanceRange.min, distanceRange.max);
        float randomHeight = Random.Range(heightRange.min, heightRange.max);

        first.top.localPosition = Vector3.up * (randomGap / 2f);
        first.bottom.localPosition = Vector3.down * (randomGap / 2f);

        first.transform.position = Last().position + new Vector3(randomDistance, randomHeight, 0f);
        CheckBorders(first);

        first.transform.SetAsLastSibling();
    }

    [System.Serializable]
    public struct ValueRange{public float min, max;}
}
