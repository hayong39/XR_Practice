using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        print("X for MENU");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X)) {
            if(animator.GetInteger("control") == 0 || animator.GetInteger("control") == 2)
            {
                print("Panel Moving Up");
                animator.SetInteger("control", 1);
            }else if(animator.GetInteger("control") == 1)
            {
                print("Panel Moving Down");
                animator.SetInteger("control", 2);
            }
            
        }
    }
}
