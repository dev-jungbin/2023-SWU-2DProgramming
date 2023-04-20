using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class MousePos : MonoBehaviour
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

        print("스크린 위치: " + screenPos);
        print("월드 좌표계 위치: " + worldPos);
    }
}
