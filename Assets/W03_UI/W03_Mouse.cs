using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W03_Mouse : MonoBehaviour
{
    private void OnMouseDown()
    {
        print(gameObject.name); //gameObject는 스크립트가 포함되어 있는 오브젝트 지칭
    }

    private void OnMouseUp() 
    {
        print(transform.position);
    }
}
