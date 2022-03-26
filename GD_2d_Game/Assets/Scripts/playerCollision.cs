using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            playerManager.isGameOver = true;
            CameraShake.shakeIt = true;
            gameObject.SetActive(false);
        }

        if(collision.transform.tag == "Win")
        {
            CameraShake.shakeIt = true;
            Score.oneScore = true;
            Debug.Log("Point");
        }
    }
}
