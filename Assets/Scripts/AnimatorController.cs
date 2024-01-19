using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        //Cursor.visible = false;
    }

    public void PlayAnimation(string animationName)
    {
        anim.Play(animationName);
    }
}
