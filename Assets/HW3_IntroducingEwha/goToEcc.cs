using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToEcc : MonoBehaviour
{
    public GameObject panel;

    public void OnClick_eccYes()
    {
        print("click yes button");
        SceneManager.LoadScene("ECC");

    }

    public void OnClick_eccNo()
    {
        print("click no button");
        panel.gameObject.SetActive(false);
    }
}
