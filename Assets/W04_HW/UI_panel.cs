using UnityEngine;

public class Ul_panel : MonoBehaviour
{
    public GameObject panel; // UI Panel을 할당할 변수
    public float slideSpeed = 5.0f; // 슬라이드 속도

    private bool isPanelVisible = false; // 현재 패널이 보이는지 여부를 추적하는 변수

    void Update()
    {
        // X 키를 누르면 패널을 보이게 하거나 감춥니다.
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (isPanelVisible)
            {
                SlidePanelDown();
            }
            else
            {
                SlidePanelUp();
            }
        }
    }

    // UI Panel을 위로 슬라이드하는 함수
    void SlidePanelUp()
    {
        // 패널의 로컬 포지션을 변경하여 위로 이동시킵니다.
        panel.transform.localPosition += new Vector3(0, panel.GetComponent<RectTransform>().rect.height, 0) * Time.deltaTime * slideSpeed;
        isPanelVisible = true;
    }

    // UI Panel을 아래로 슬라이드하는 함수
    void SlidePanelDown()
    {
        // 패널의 로컬 포지션을 변경하여 아래로 이동시킵니다.
        panel.transform.localPosition -= new Vector3(0, panel.GetComponent<RectTransform>().rect.height, 0) * Time.deltaTime * slideSpeed;
        isPanelVisible = false;
    }
}