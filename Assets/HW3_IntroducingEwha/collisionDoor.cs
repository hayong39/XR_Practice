using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDoor : MonoBehaviour
{
    public GameObject panel_chapel;
    public GameObject panel_ecc;

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
     
        if (collision.gameObject.CompareTag("chapel_door"))
        {
            print("chapel door collision");
            panel_chapel.SetActive(true);
        }

        if (collision.gameObject.CompareTag("ecc_door"))
        {
            print("ecc door collision");
            panel_ecc.SetActive(true);
        }
    }

}
