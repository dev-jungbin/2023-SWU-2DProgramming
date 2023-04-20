using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class MousePosClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 screenPos = Input.mousePosition;
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(screenPos);

        if (Input.GetMouseButton(0))
        {
            print("클릭한 스크린 좌표 위치: " + screenPos);
        }
        
        if (Input.GetMouseButton(1))
        {
            print("클릭한 월드 좌표 위치: " + worldPos);
        }
    }
}
