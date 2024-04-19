using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_chapel_NPC : MonoBehaviour
{
    public GameObject panel1;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("NPC"))
        {
            print("chapel NPC collision");
            panel1.SetActive(true);
        }

    }

}
