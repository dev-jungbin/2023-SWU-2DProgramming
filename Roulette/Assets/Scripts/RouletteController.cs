using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // 회전 속도

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 클릭하면 회전 속도 설정
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }

        // 회전 속도만큼 룰렛 회전
        transform.Rotate(0, 0, this.rotSpeed);

        // 룰렛 회전 속도를 감속시킴
        this.rotSpeed *= 0.98f;
    }
}
