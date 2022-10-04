using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorAnimatorController : MonoBehaviour
{
    [SerializeField]
    private Animator doorAnimator;



    public void doorOpening()
    {
        doorAnimator.SetBool("character_nearby", true);
        Invoke("doorClosing", 3.0f);
    }

    public void doorClosing()
    {
        doorAnimator.SetBool("character_nearby", false);
    }
}
