using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    public Animator animator;
    

    
    public void FadeHit()
    {
        animator.Play("Golpe");
    }
    public void FadeOut()
    {
        animator.Play("Fin");
    }
}
