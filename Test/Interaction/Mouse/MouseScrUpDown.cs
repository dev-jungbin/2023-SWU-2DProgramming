using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScrUpDown: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 위로 스크롤
        if (Input.mouseScrollDelta.y > 0)
        {
            print("���� ��ũ��");
        }
        else if (Input.mouseScrollDelta.y < 0) // 아래로 스크롤시
        {
            print("�Ʒ��� ��ũ��");
        }


    }
}
