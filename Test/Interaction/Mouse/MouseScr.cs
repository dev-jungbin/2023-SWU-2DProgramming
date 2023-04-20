using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 마우스휠버튼스크롤시값출력
        if (Input.mouseScrollDelta.y != 0)
        {
            print(Input.mouseScrollDelta);
        }
    }
}
