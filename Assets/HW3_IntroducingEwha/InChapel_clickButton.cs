using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InChapel_clickButton : MonoBehaviour
{
    public GameObject panel1;
    public GameObject introduction_panel;
    public GameObject chapelInformatioon_panel;

    public void OnClick_introduction()
    {
        print("introduction");
        panel1.gameObject.SetActive(false);
        introduction_panel.gameObject.SetActive(true);
    }

    public void OnClick_chapelInfromation()
    {
        print("chapel Information");
        panel1.gameObject.SetActive(false);   
        chapelInformatioon_panel.gameObject.SetActive(true);
    }

    public void Onclick_closePanel1() 
    {
        print("close panel");
        panel1.gameObject.SetActive(false); 
    }

    public void Onclick_closePanel2()
    {
        print("close panel");
        introduction_panel.gameObject.SetActive(false);
    }

    public void Onclick_closePanel3()
    {
        print("close panel");
        chapelInformatioon_panel.gameObject.SetActive(false);
    }

    public void Onclick_goToEwha() 
    {
        print("go to ewha");
        SceneManager.LoadScene("HW3_Ewha");
    }
}
