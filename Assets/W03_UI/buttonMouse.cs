using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("hello");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            print("Mouse 0");
        } //마우스의 메인 버튼이 눌렸는지 확인하는 코드
    }
}
