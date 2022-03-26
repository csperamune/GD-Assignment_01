using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : MonoBehaviour
{
    public int pickupVal = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Score scoreScript = other.GetComponent<Score>();

        if(scoreScript != null)
        {
            scoreScript.AddScore(pickupVal);
            Destroy(gameObject);
        }
    }
}
