using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cube_collision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "player")
        {
            print(collision.gameObject.name);
        }
    }

}
