using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W03_Mouse : MonoBehaviour
{
    private void OnMouseDown()
    {
        print(gameObject.name); //gameObject�� ��ũ��Ʈ�� ���ԵǾ� �ִ� ������Ʈ ��Ī
    }

    private void OnMouseUp() 
    {
        print(transform.position);
    }
}
