using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "Obstacle":
                //Debug.Log("kuş yarra yedi!");
                break;
            case "Obstacle Group":
                //Debug.Log("kuş puan topladu!");
                break;
        }
    }
}
