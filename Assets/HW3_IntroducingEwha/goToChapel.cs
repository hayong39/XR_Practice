using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class goToChapel : MonoBehaviour
{
    public GameObject panel;

    public void OnClick_chapelYes() 
    {
        print("click yes button");
        SceneManager.LoadScene("chapel");

    }

    public void OnClick_chapelNo() 
    {
        print("click no button");
        panel.gameObject.SetActive(false);
    }
}
