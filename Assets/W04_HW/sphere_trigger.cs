using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere_trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "player")
        {
            print(collision.gameObject.name);
        }
    }

}
