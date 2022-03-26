using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public static bool shakeIt;
    public Animator camAnim;

    public void camShake()
    {
        if(shakeIt == true)
        {
            camAnim.SetTrigger("CameraAnimation");
        }

    }
}
