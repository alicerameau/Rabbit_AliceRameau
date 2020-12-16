using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    public int score = 0;

    void OnTriggerEnter(Collider col)
    {
       
        if (col.tag == "Coin")
        {
            Destroy(col.gameObject);
            score += 1;
        }
    }
}