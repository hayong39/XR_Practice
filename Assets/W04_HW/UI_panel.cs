using UnityEngine;

public class Ul_panel : MonoBehaviour
{
    public GameObject panel; // UI Panel�� �Ҵ��� ����
    public float slideSpeed = 5.0f; // �����̵� �ӵ�

    private bool isPanelVisible = false; // ���� �г��� ���̴��� ���θ� �����ϴ� ����

    void Update()
    {
        // X Ű�� ������ �г��� ���̰� �ϰų� ����ϴ�.
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

    // UI Panel�� ���� �����̵��ϴ� �Լ�
    void SlidePanelUp()
    {
        // �г��� ���� �������� �����Ͽ� ���� �̵���ŵ�ϴ�.
        panel.transform.localPosition += new Vector3(0, panel.GetComponent<RectTransform>().rect.height, 0) * Time.deltaTime * slideSpeed;
        isPanelVisible = true;
    }

    // UI Panel�� �Ʒ��� �����̵��ϴ� �Լ�
    void SlidePanelDown()
    {
        // �г��� ���� �������� �����Ͽ� �Ʒ��� �̵���ŵ�ϴ�.
        panel.transform.localPosition -= new Vector3(0, panel.GetComponent<RectTransform>().rect.height, 0) * Time.deltaTime * slideSpeed;
        isPanelVisible = false;
    }
}