using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class serveplate : MonoBehaviour
{
    List<Transform> food = new List<Transform>();

    public void AddFood(Transform item)
    {
        food.Add(item);
    }

    public void ClearPlate()
    {
        foreach(Transform item in food)
        {
            Destroy(item.gameObject);
        }
        food.Clear();
        gameflow.plateValue = 0;
    }

    private void OnMouseDown()
    {
        if (gameflow.orderValue==gameflow.plateValue)
        {
            Debug.Log("correct");
        }

        else
        {
            Debug.Log("incorrect");
        }
    }
}
