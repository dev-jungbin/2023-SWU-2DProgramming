using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardRightArrow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            print("이동준비");
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            print("정지");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            print("이동 중");
        }
    }
}
