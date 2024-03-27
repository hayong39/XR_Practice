using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W04_DoorControl : MonoBehaviour
{

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Robot_Transform") 
        {
            print("trigger enter");
            animator.SetInteger("control", 1);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Robot_Transform")
        {
            print("trigger exit");
            animator.SetInteger("control", 2);
        }
    }
}
