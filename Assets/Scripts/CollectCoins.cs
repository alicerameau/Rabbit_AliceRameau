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
            Feed();
            score += 1;
            Destroy(col.gameObject);
        }
    }

    void Feed()
    {
        ParticleSystem exp = GetComponent<ParticleSystem>();
        exp.Play();
    }
}